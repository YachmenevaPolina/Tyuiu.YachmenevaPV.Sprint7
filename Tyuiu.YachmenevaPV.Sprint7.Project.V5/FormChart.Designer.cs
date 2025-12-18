namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5
{
    partial class FormChart_YPV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart_YPV));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTopChart_YPV = new Panel();
            buttonBackChart_YPV = new Button();
            labelNameChart_YPV = new Label();
            dataGridViewChart_YPV = new DataGridView();
            panel1 = new Panel();
            buttonOpenChart_YPV = new Button();
            buttonSave_YPV = new Button();
            buttonChartAdd_YPV = new Button();
            buttonDelete_YPV = new Button();
            buttonDoneChart_YPV = new Button();
            panel2 = new Panel();
            chart_YPV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolTipChart_YPV = new ToolTip(components);
            openFileDialogChart_YPV = new OpenFileDialog();
            saveFileDialogChart_YPV = new SaveFileDialog();
            panel3 = new Panel();
            panelTopChart_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChart_YPV).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_YPV).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopChart_YPV
            // 
            panelTopChart_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTopChart_YPV.BackColor = Color.PowderBlue;
            panelTopChart_YPV.Controls.Add(buttonBackChart_YPV);
            panelTopChart_YPV.Controls.Add(labelNameChart_YPV);
            panelTopChart_YPV.Location = new Point(3, -2);
            panelTopChart_YPV.Name = "panelTopChart_YPV";
            panelTopChart_YPV.Size = new Size(2879, 239);
            panelTopChart_YPV.TabIndex = 0;
            // 
            // buttonBackChart_YPV
            // 
            buttonBackChart_YPV.Image = (Image)resources.GetObject("buttonBackChart_YPV.Image");
            buttonBackChart_YPV.Location = new Point(47, 48);
            buttonBackChart_YPV.Name = "buttonBackChart_YPV";
            buttonBackChart_YPV.Size = new Size(222, 126);
            buttonBackChart_YPV.TabIndex = 1;
            buttonBackChart_YPV.UseVisualStyleBackColor = true;
            buttonBackChart_YPV.Click += buttonBackChart_YPV_Click;
            // 
            // labelNameChart_YPV
            // 
            labelNameChart_YPV.Anchor = AnchorStyles.Top;
            labelNameChart_YPV.AutoSize = true;
            labelNameChart_YPV.Font = new Font("Microsoft Sans Serif", 26.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNameChart_YPV.ForeColor = SystemColors.MenuHighlight;
            labelNameChart_YPV.Location = new Point(941, 76);
            labelNameChart_YPV.Name = "labelNameChart_YPV";
            labelNameChart_YPV.Size = new Size(1205, 98);
            labelNameChart_YPV.TabIndex = 0;
            labelNameChart_YPV.Text = "ДИАГРАММА СТОИМОСТИ";
            // 
            // dataGridViewChart_YPV
            // 
            dataGridViewChart_YPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChart_YPV.Dock = DockStyle.Fill;
            dataGridViewChart_YPV.Location = new Point(0, 0);
            dataGridViewChart_YPV.Name = "dataGridViewChart_YPV";
            dataGridViewChart_YPV.RowHeadersVisible = false;
            dataGridViewChart_YPV.RowHeadersWidth = 102;
            dataGridViewChart_YPV.Size = new Size(1561, 1012);
            dataGridViewChart_YPV.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(dataGridViewChart_YPV);
            panel1.Location = new Point(3, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(1561, 1012);
            panel1.TabIndex = 2;
            // 
            // buttonOpenChart_YPV
            // 
            buttonOpenChart_YPV.Cursor = Cursors.Hand;
            buttonOpenChart_YPV.Image = (Image)resources.GetObject("buttonOpenChart_YPV.Image");
            buttonOpenChart_YPV.Location = new Point(1602, 265);
            buttonOpenChart_YPV.Name = "buttonOpenChart_YPV";
            buttonOpenChart_YPV.Size = new Size(188, 114);
            buttonOpenChart_YPV.TabIndex = 3;
            toolTipChart_YPV.SetToolTip(buttonOpenChart_YPV, "Загрузить данные");
            buttonOpenChart_YPV.UseVisualStyleBackColor = true;
            buttonOpenChart_YPV.Click += buttonOpenChart_YPV_Click;
            // 
            // buttonSave_YPV
            // 
            buttonSave_YPV.Cursor = Cursors.Hand;
            buttonSave_YPV.Image = (Image)resources.GetObject("buttonSave_YPV.Image");
            buttonSave_YPV.Location = new Point(1602, 406);
            buttonSave_YPV.Name = "buttonSave_YPV";
            buttonSave_YPV.Size = new Size(188, 114);
            buttonSave_YPV.TabIndex = 4;
            toolTipChart_YPV.SetToolTip(buttonSave_YPV, "Сохранить данные");
            buttonSave_YPV.UseVisualStyleBackColor = true;
            buttonSave_YPV.Click += buttonSave_YPV_Click;
            // 
            // buttonChartAdd_YPV
            // 
            buttonChartAdd_YPV.Cursor = Cursors.Hand;
            buttonChartAdd_YPV.Image = (Image)resources.GetObject("buttonChartAdd_YPV.Image");
            buttonChartAdd_YPV.Location = new Point(1602, 547);
            buttonChartAdd_YPV.Name = "buttonChartAdd_YPV";
            buttonChartAdd_YPV.Size = new Size(188, 114);
            buttonChartAdd_YPV.TabIndex = 5;
            toolTipChart_YPV.SetToolTip(buttonChartAdd_YPV, "Добавить строку");
            buttonChartAdd_YPV.UseVisualStyleBackColor = true;
            buttonChartAdd_YPV.Click += buttonChartAdd_YPV_Click;
            // 
            // buttonDelete_YPV
            // 
            buttonDelete_YPV.Cursor = Cursors.Hand;
            buttonDelete_YPV.Image = (Image)resources.GetObject("buttonDelete_YPV.Image");
            buttonDelete_YPV.Location = new Point(1602, 688);
            buttonDelete_YPV.Name = "buttonDelete_YPV";
            buttonDelete_YPV.Size = new Size(188, 114);
            buttonDelete_YPV.TabIndex = 6;
            toolTipChart_YPV.SetToolTip(buttonDelete_YPV, "Удалить строку");
            buttonDelete_YPV.UseVisualStyleBackColor = true;
            buttonDelete_YPV.Click += buttonDelete_YPV_Click;
            // 
            // buttonDoneChart_YPV
            // 
            buttonDoneChart_YPV.BackColor = Color.PowderBlue;
            buttonDoneChart_YPV.Cursor = Cursors.Hand;
            buttonDoneChart_YPV.Font = new Font("Microsoft Sans Serif", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDoneChart_YPV.Location = new Point(20, 10);
            buttonDoneChart_YPV.Name = "buttonDoneChart_YPV";
            buttonDoneChart_YPV.Size = new Size(315, 140);
            buttonDoneChart_YPV.TabIndex = 7;
            buttonDoneChart_YPV.Text = "Выполнить";
            toolTipChart_YPV.SetToolTip(buttonDoneChart_YPV, "Построить диаграмму средней стоимости каждой категории\r\n");
            buttonDoneChart_YPV.UseVisualStyleBackColor = false;
            buttonDoneChart_YPV.Click += buttonDoneChart_YPV_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(chart_YPV);
            panel2.Location = new Point(1858, 411);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 840);
            panel2.TabIndex = 10;
            // 
            // chart_YPV
            // 
            chartArea1.Name = "ChartArea1";
            chart_YPV.ChartAreas.Add(chartArea1);
            chart_YPV.Dock = DockStyle.Fill;
            chart_YPV.Location = new Point(0, 0);
            chart_YPV.Name = "chart_YPV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            chart_YPV.Series.Add(series1);
            chart_YPV.Size = new Size(1024, 840);
            chart_YPV.TabIndex = 0;
            chart_YPV.Text = "chart1";
            // 
            // toolTipChart_YPV
            // 
            toolTipChart_YPV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogChart_YPV
            // 
            openFileDialogChart_YPV.FileName = "openFileDialog1";
            // 
            // saveFileDialogChart_YPV
            // 
            saveFileDialogChart_YPV.FileName = "diagram.png";
            saveFileDialogChart_YPV.Filter = "PNG (*.png)|*.png|JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(buttonDoneChart_YPV);
            panel3.Location = new Point(1857, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(1014, 153);
            panel3.TabIndex = 11;
            // 
            // FormChart_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2883, 1251);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonDelete_YPV);
            Controls.Add(buttonChartAdd_YPV);
            Controls.Add(buttonSave_YPV);
            Controls.Add(buttonOpenChart_YPV);
            Controls.Add(panel1);
            Controls.Add(panelTopChart_YPV);
            Name = "FormChart_YPV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Диаграмма стоимости";
            panelTopChart_YPV.ResumeLayout(false);
            panelTopChart_YPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChart_YPV).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_YPV).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopChart_YPV;
        private Label labelNameChart_YPV;
        private Button buttonBackChart_YPV;
        private DataGridView dataGridViewChart_YPV;
        private Panel panel1;
        private Button buttonOpenChart_YPV;
        private Button buttonSave_YPV;
        private Button buttonChartAdd_YPV;
        private Button buttonDelete_YPV;
        private Button buttonDoneChart_YPV;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_YPV;
        private ToolTip toolTipChart_YPV;
        private OpenFileDialog openFileDialogChart_YPV;
        private SaveFileDialog saveFileDialogChart_YPV;
        private Panel panel3;
    }
}