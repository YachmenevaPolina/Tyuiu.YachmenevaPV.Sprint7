using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.YachmenevaPV.Sprint7.Project.V5.Lib;

namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5
{
    public partial class FormSuppliers_YPV : Form
    {

        private string openFilePath = string.Empty;
        private DataService ds = new DataService();

        public FormSuppliers_YPV()
        {
            InitializeComponent();
        }

        private void buttonBackSuppliers_YPV_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain_YPV().Show();
        }

        private void buttonOpenSuppliers_YPV_Click(object sender, EventArgs e)
        {
            if (openFileDialogSuppliers_YPV.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                openFilePath = openFileDialogSuppliers_YPV.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                dataGridViewSuppliers_YPV.Rows.Clear();
                dataGridViewSuppliers_YPV.ColumnCount = columns;
                dataGridViewSuppliers_YPV.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewSuppliers_YPV.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }

                dataGridViewSuppliers_YPV.BackgroundColor = Color.White;
                dataGridViewSuppliers_YPV.BorderStyle = BorderStyle.None;

                dataGridViewSuppliers_YPV.EnableHeadersVisualStyles = false;
                dataGridViewSuppliers_YPV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 230, 235);
                dataGridViewSuppliers_YPV.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridViewSuppliers_YPV.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dataGridViewSuppliers_YPV.ColumnHeadersHeight = 35;
                dataGridViewSuppliers_YPV.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewSuppliers_YPV.DefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Regular);

                dataGridViewSuppliers_YPV.RowHeadersVisible = false;
                dataGridViewSuppliers_YPV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSuppliers_YPV.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.FromArgb(245, 250, 252);

                dataGridViewSuppliers_YPV.ScrollBars = ScrollBars.Both;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при загрузке файла:\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void buttonSuppliersSave_YPV_Click(object sender, EventArgs e)
        {
            if (saveFileDialogSuppliers_YPV.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using StreamWriter writer = new StreamWriter(
                    saveFileDialogSuppliers_YPV.FileName,
                    false,
                    Encoding.UTF8
                );

                for (int i = 0; i < dataGridViewSuppliers_YPV.Rows.Count; i++)
                {
                    if (dataGridViewSuppliers_YPV.Rows[i].IsNewRow)
                        continue;

                    for (int j = 0; j < dataGridViewSuppliers_YPV.Columns.Count; j++)
                    {
                        writer.Write(dataGridViewSuppliers_YPV.Rows[i].Cells[j].Value);

                        if (j < dataGridViewSuppliers_YPV.Columns.Count - 1)
                            writer.Write(";");
                    }
                    writer.WriteLine();
                }

                MessageBox.Show("Файл успешно сохранён", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при сохранении:\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonAddSuppliers_YPV_Click(object sender, EventArgs e)
        {
            dataGridViewSuppliers_YPV.Rows.Add();
        }

        private void buttonDelete_YPV_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers_YPV.CurrentRow == null)
                return;

            var result = MessageBox.Show(
                "Удалить выбранную строку?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                dataGridViewSuppliers_YPV.Rows.Remove(dataGridViewSuppliers_YPV.CurrentRow);
            }
        }

        private void comboBoxFiltSuppliers_YPV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltSuppliers_YPV.SelectedItem == null)
                return;

            string filterValue = comboBoxFiltSuppliers_YPV.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridViewSuppliers_YPV.Rows)
            {
                if (row.IsNewRow) continue;

                if (filterValue == "Все")
                {
                    row.Visible = true;
                    continue;
                }

                var cellValue = row.Cells[3].Value; // индекс столбца "Месяц поставки"

                row.Visible = cellValue != null && cellValue.ToString() == filterValue;
            }
        }
    }
}
