using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.YachmenevaPV.Sprint7.Project.V5.Lib;

namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5
{
    public partial class FormChart_YPV : Form
    {
        private string? openFilePath;
        private readonly DataService ds = new();

        public FormChart_YPV()
        {
            InitializeComponent();
        }

        private void buttonBackChart_YPV_Click(object sender, EventArgs e)
        {
            Hide();
            new FormMain_YPV().Show();
        }

        private void buttonOpenChart_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogChart_YPV.ShowDialog() != DialogResult.OK)
                    return;

                openFilePath = openFileDialogChart_YPV.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                dataGridViewChart_YPV.Rows.Clear();
                dataGridViewChart_YPV.Columns.Clear();

                dataGridViewChart_YPV.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    dataGridViewChart_YPV.Rows.Add();
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewChart_YPV.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }

                dataGridViewChart_YPV.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                if (chart_YPV.Series.Count == 0)
                {
                    MessageBox.Show("Диаграмма не построена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                saveFileDialogChart_YPV.Filter = "PNG (*.png)|*.png|JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp";
                
                saveFileDialogChart_YPV.FileName = "diagram.png";

                if (saveFileDialogChart_YPV.ShowDialog() != DialogResult.OK)
                    return;

                ChartImageFormat format = ChartImageFormat.Png;

                switch (Path.GetExtension(saveFileDialogChart_YPV.FileName).ToLower())
                {
                    case ".jpg":
                        format = ChartImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ChartImageFormat.Bmp;
                        break;
                }

                chart_YPV.SaveImage(
                    saveFileDialogChart_YPV.FileName,
                    format);

                MessageBox.Show("Диаграмма успешно сохранена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения диаграммы:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void buttonChartAdd_YPV_Click(object sender, EventArgs e)
        {
            dataGridViewChart_YPV.Rows.Add();
        }

        private void buttonDelete_YPV_Click(object sender, EventArgs e)
        {
            if (dataGridViewChart_YPV.CurrentRow is null)
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            if (MessageBox.Show("Удалить выбранную строку?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                
            {
                dataGridViewChart_YPV.Rows.Remove(dataGridViewChart_YPV.CurrentRow);
            }
        }

        private void buttonDoneChart_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                chart_YPV.Series.Clear();
                chart_YPV.Titles.Clear();

                // Категория, список цен
                Dictionary<string, List<double>> categoryPrices = new();

                foreach (DataGridViewRow row in dataGridViewChart_YPV.Rows)
                {
                    if (row.IsNewRow) continue;

                    string category = row.Cells[2]?.Value?.ToString() ?? "";
                    string priceText = row.Cells[4]?.Value?.ToString() ?? "";

                    if (string.IsNullOrWhiteSpace(category))
                        continue;

                    priceText = priceText.Replace(',', '.');

                    if (!double.TryParse(
                            priceText,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture,
                            out double price))
                        continue;

                    if (!categoryPrices.ContainsKey(category))
                        categoryPrices[category] = new List<double>();

                    categoryPrices[category].Add(price);
                }

                Series series = new Series("Средняя стоимость")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true
                };

                foreach (var pair in categoryPrices)
                {
                    double avg = pair.Value.Average();
                    int pointIndex = series.Points.AddXY(pair.Key, avg);

                    // подпись: категория, значение
                    series.Points[pointIndex].Label = $"{pair.Key}\n{avg:F2}";
                    
                }

                chart_YPV.Series.Add(series);
                chart_YPV.Titles.Add("Средняя стоимость по категориям");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка построения диаграммы:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        
    }
}
