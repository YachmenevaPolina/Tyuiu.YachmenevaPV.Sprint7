using System.ComponentModel;
using System.Text;
using Tyuiu.YachmenevaPV.Sprint7.Project.V5.Lib;

namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5
{
    public partial class FormMain_YPV : Form
    {

        private int rows;
        private int columns;
        private string? openFilePath;
        private string[,]? gridData;
        private List<string[]> allData = new();
        private readonly DataService ds = new();

        public FormMain_YPV()
        {
            InitializeComponent();
        }

        private void buttonSave_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_YPV.FileName = "data.csv";

                if (saveFileDialogMain_YPV.ShowDialog() != DialogResult.OK)
                    return;

                StringBuilder sb = new();

                foreach (DataGridViewRow row in dataGridViewMain_YPV.Rows)
                {
                    if (row.IsNewRow || !row.Visible)
                        continue;

                    for (int j = 0; j < dataGridViewMain_YPV.Columns.Count; j++)
                    {
                        sb.Append(row.Cells[j].Value?.ToString());
                        if (j < dataGridViewMain_YPV.Columns.Count - 1)
                            sb.Append(";");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(
                    saveFileDialogMain_YPV.FileName,
                    sb.ToString(),
                    Encoding.GetEncoding(1251));

                MessageBox.Show("Файл успешно сохранён",
                    "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_YPV_Click(object sender, EventArgs e)
        {
            new FormAbout_YPV().ShowDialog();
        }

        private void buttonHelp_YPV_Click(object sender, EventArgs e)
        {
            new FormGuide_YPV().ShowDialog();
        }

        private void buttonSum_YPV_Click(object sender, EventArgs e)
        {
            double sum = 0;
            bool found = false;

            foreach (DataGridViewRow row in dataGridViewMain_YPV.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                if (double.TryParse(
                    row.Cells[4].Value?.ToString(),
                    out double value))
                {
                    sum += value;
                    found = true;
                }
            }

            textBoxSum_YPV.Text = found
                ? Math.Round(sum, 2).ToString()
                : "Нет данных";
        }

        private void buttonAverage_YPV_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridViewMain_YPV.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                if (double.TryParse(
                    row.Cells[4].Value?.ToString(),
                    out double value))
                {
                    sum += value;
                    count++;
                }
            }

            textBoxAverage_YPV.Text = count > 0
                ? Math.Round(sum / count, 2).ToString()
                : "Нет данных";

        }

        private void buttonMin_YPV_Click(object sender, EventArgs e)
        {
            double min = double.MaxValue;
            bool found = false;

            foreach (DataGridViewRow row in dataGridViewMain_YPV.Rows)
            {
                if (row.IsNewRow || !row.Visible)
                    continue;

                if (double.TryParse(
                    row.Cells[4].Value?.ToString(),
                    out double value))
                {
                    min = Math.Min(min, value);
                    found = true;
                }
            }

            textBoxMin_YPV.Text = found ? min.ToString() : "Нет данных";
        }

        private void buttonMax_YPV_Click(object sender, EventArgs e)
        {
            double max = double.MinValue;
            bool found = false;

            foreach (DataGridViewRow row in dataGridViewMain_YPV.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                if (double.TryParse(
                    row.Cells[4].Value?.ToString(),
                    out double value))
                {
                    max = Math.Max(max, value);
                    found = true;
                }
            }

            textBoxMax_YPV.Text = found
                ? max.ToString()
                : "Нет данных";
        }

        private void buttonChart_YPV_Click(object sender, EventArgs e)
        {
            Hide();
            new FormChart_YPV().Show();
        }

        private void buttonSuppliers_YPV_Click(object sender, EventArgs e)
        {
            Hide();
            new FormSuppliers_YPV().Show();
        }

        private void dataGridViewMain_YPV_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            // Колонка "Количество" (индекс 3)
            if (e.ColumnIndex != 3)
                return;

            if (e.Value == null)
                return;

            string text = e.Value.ToString()!.Replace(',', '.');

            if (double.TryParse(
                text,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double cellValue))
            {
                e.Value = cellValue;
                e.ParsingApplied = true;
            }
        }

        private void dataGridViewMain_YPV_CellContentClick(object sender, EventArgs e)
        {

        }

        private void buttonOpen_YPV_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogMain_YPV.ShowDialog() != DialogResult.OK)
                    return;

                openFilePath = openFileDialogMain_YPV.FileName;
                gridData = ds.LoadFromDataFile(openFilePath);

                rows = gridData.GetLength(0);
                columns = gridData.GetLength(1);

                dataGridViewMain_YPV.Rows.Clear();
                dataGridViewMain_YPV.Columns.Clear();
                dataGridViewMain_YPV.ColumnCount = columns;

                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMain_YPV.Columns[j].HeaderText = gridData[0, j];
                }

                // ===== Данные (НАЧИНАЕМ С 1!) =====
                allData.Clear(); // ← ОЧИЩАЕМ ПЕРЕД ЗАГРУЗКОЙ

                for (int i = 1; i < rows; i++)
                {
                    string[] row = new string[columns];

                    for (int j = 0; j < columns; j++)
                        row[j] = gridData[i, j];

                    allData.Add(row);
                }

                // отрисовываем таблицу
                ApplyFilterAndSort();

                dataGridViewMain_YPV.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия файла:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_YPV_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch_YPV.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridViewMain_YPV.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = false;

                // Проверяем первые 3 колонки: Код, Название, Категория
                for (int i = 0; i <= 2; i++)
                {
                    var cellValue = row.Cells[i].Value?.ToString()?.ToLower();

                    if (!string.IsNullOrEmpty(cellValue) &&
                        cellValue.Contains(search))
                    {
                        visible = true;
                        break;
                    }
                }

                row.Visible = visible;
            }
        }

        private void ApplyFilterAndSort()
        {
            IEnumerable<string[]> data = allData;

            // ===== ФИЛЬТР ПО КАТЕГОРИИ =====
            string category = comboBoxFilt_YPV.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(category) && category != "Все")
            {
                data = data.Where(r => r[2] == category); // колонка "Категория"
            }

            // ===== СОРТИРОВКА =====
            string sortMode = comboBoxSort_YPV.SelectedItem?.ToString();
            int qtyIndex = 3;

            if (sortMode == "Min")
            {
                data = data.OrderBy(r =>
                    int.TryParse(r[qtyIndex], out int v) ? v : int.MaxValue);
            }
            else if (sortMode == "Max")
            {
                data = data.OrderByDescending(r =>
                    int.TryParse(r[qtyIndex], out int v) ? v : int.MinValue);
            }

            // ===== ОБНОВЛЕНИЕ ТАБЛИЦЫ =====
            dataGridViewMain_YPV.Rows.Clear();
            foreach (var row in data)
                dataGridViewMain_YPV.Rows.Add(row);
        }
        private void comboBoxFilt_YPV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        
        private void comboBoxSort_YPV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void RedrawTable(List<string[]> data)
        {
            dataGridViewMain_YPV.Rows.Clear();

            foreach (var row in data)
                dataGridViewMain_YPV.Rows.Add(row);
        }
        private void RestoreOriginalData()
        {
            int rows = gridData.GetLength(0);
            int columns = gridData.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMain_YPV.Rows[i].Cells[j].Value = gridData[i, j];
                }
                dataGridViewMain_YPV.Rows[i].Visible = true;
            }
        }

        private void labelSearch_YPV_Click(object sender, EventArgs e)
        {

        }
    }
}
