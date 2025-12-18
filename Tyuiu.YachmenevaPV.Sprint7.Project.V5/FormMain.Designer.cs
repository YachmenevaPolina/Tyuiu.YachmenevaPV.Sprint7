namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5
{
    partial class FormMain_YPV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_YPV));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop_YPV = new Panel();
            buttonHelp_YPV = new Button();
            buttonInfo_YPV = new Button();
            labelName_YPV = new Label();
            panel1 = new Panel();
            dataGridViewMain_YPV = new DataGridView();
            labelSearch_YPV = new Label();
            textBoxSearch_YPV = new TextBox();
            groupBoxFilt_YPV = new GroupBox();
            comboBoxFilt_YPV = new ComboBox();
            groupBoxSort_YPV = new GroupBox();
            comboBoxSort_YPV = new ComboBox();
            buttonSum_YPV = new Button();
            buttonAverage_YPV = new Button();
            buttonMin_YPV = new Button();
            buttonMax_YPV = new Button();
            textBoxSum_YPV = new TextBox();
            textBoxAverage_YPV = new TextBox();
            textBoxMin_YPV = new TextBox();
            textBoxMax_YPV = new TextBox();
            buttonChart_YPV = new Button();
            buttonSuppliers_YPV = new Button();
            toolTip_YPV = new ToolTip(components);
            buttonSave_YPV = new Button();
            buttonOpen_YPV = new Button();
            openFileDialogMain_YPV = new OpenFileDialog();
            saveFileDialogMain_YPV = new SaveFileDialog();
            panelSearch_YPV = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelTop_YPV.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_YPV).BeginInit();
            groupBoxFilt_YPV.SuspendLayout();
            groupBoxSort_YPV.SuspendLayout();
            panelSearch_YPV.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_YPV
            // 
            panelTop_YPV.BackColor = Color.PowderBlue;
            panelTop_YPV.Controls.Add(buttonHelp_YPV);
            panelTop_YPV.Controls.Add(buttonInfo_YPV);
            panelTop_YPV.Controls.Add(labelName_YPV);
            panelTop_YPV.Dock = DockStyle.Top;
            panelTop_YPV.Location = new Point(0, 0);
            panelTop_YPV.Name = "panelTop_YPV";
            panelTop_YPV.Size = new Size(2885, 206);
            panelTop_YPV.TabIndex = 0;
            // 
            // buttonHelp_YPV
            // 
            buttonHelp_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_YPV.Image = (Image)resources.GetObject("buttonHelp_YPV.Image");
            buttonHelp_YPV.Location = new Point(2444, 38);
            buttonHelp_YPV.Name = "buttonHelp_YPV";
            buttonHelp_YPV.Size = new Size(168, 129);
            buttonHelp_YPV.TabIndex = 2;
            toolTip_YPV.SetToolTip(buttonHelp_YPV, "Руководство пользователя");
            buttonHelp_YPV.UseVisualStyleBackColor = true;
            buttonHelp_YPV.Click += buttonHelp_YPV_Click;
            // 
            // buttonInfo_YPV
            // 
            buttonInfo_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_YPV.Image = (Image)resources.GetObject("buttonInfo_YPV.Image");
            buttonInfo_YPV.Location = new Point(2664, 38);
            buttonInfo_YPV.Name = "buttonInfo_YPV";
            buttonInfo_YPV.Size = new Size(168, 129);
            buttonInfo_YPV.TabIndex = 1;
            toolTip_YPV.SetToolTip(buttonInfo_YPV, "Информация о разработчике");
            buttonInfo_YPV.UseVisualStyleBackColor = true;
            buttonInfo_YPV.Click += buttonInfo_YPV_Click;
            // 
            // labelName_YPV
            // 
            labelName_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelName_YPV.AutoSize = true;
            labelName_YPV.Font = new Font("Microsoft Sans Serif", 26.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName_YPV.ForeColor = SystemColors.MenuHighlight;
            labelName_YPV.Location = new Point(1092, 54);
            labelName_YPV.Name = "labelName_YPV";
            labelName_YPV.Size = new Size(736, 98);
            labelName_YPV.TabIndex = 0;
            labelName_YPV.Text = "ОПТОВАЯ БАЗА";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(dataGridViewMain_YPV);
            panel1.Location = new Point(0, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(1463, 1276);
            panel1.TabIndex = 1;
            // 
            // dataGridViewMain_YPV
            // 
            dataGridViewMain_YPV.AllowUserToAddRows = false;
            dataGridViewMain_YPV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMain_YPV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMain_YPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMain_YPV.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMain_YPV.Dock = DockStyle.Fill;
            dataGridViewMain_YPV.Location = new Point(0, 0);
            dataGridViewMain_YPV.Name = "dataGridViewMain_YPV";
            dataGridViewMain_YPV.RowHeadersVisible = false;
            dataGridViewMain_YPV.RowHeadersWidth = 102;
            dataGridViewMain_YPV.Size = new Size(1463, 1276);
            dataGridViewMain_YPV.TabIndex = 0;
            dataGridViewMain_YPV.CellContentClick += dataGridViewMain_YPV_CellContentClick;
            dataGridViewMain_YPV.CellParsing += dataGridViewMain_YPV_CellParsing;
            // 
            // labelSearch_YPV
            // 
            labelSearch_YPV.AutoSize = true;
            labelSearch_YPV.Font = new Font("Microsoft Sans Serif", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSearch_YPV.ForeColor = SystemColors.MenuHighlight;
            labelSearch_YPV.Location = new Point(21, 20);
            labelSearch_YPV.Name = "labelSearch_YPV";
            labelSearch_YPV.Size = new Size(247, 76);
            labelSearch_YPV.TabIndex = 4;
            labelSearch_YPV.Text = "Поиск:";
            labelSearch_YPV.Click += labelSearch_YPV_Click;
            // 
            // textBoxSearch_YPV
            // 
            textBoxSearch_YPV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch_YPV.Location = new Point(274, 31);
            textBoxSearch_YPV.Multiline = true;
            textBoxSearch_YPV.Name = "textBoxSearch_YPV";
            textBoxSearch_YPV.Size = new Size(784, 65);
            textBoxSearch_YPV.TabIndex = 5;
            textBoxSearch_YPV.TextChanged += textBoxSearch_YPV_TextChanged;
            // 
            // groupBoxFilt_YPV
            // 
            groupBoxFilt_YPV.Controls.Add(comboBoxFilt_YPV);
            groupBoxFilt_YPV.Font = new Font("Microsoft Sans Serif", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxFilt_YPV.Location = new Point(21, 17);
            groupBoxFilt_YPV.Name = "groupBoxFilt_YPV";
            groupBoxFilt_YPV.Size = new Size(534, 167);
            groupBoxFilt_YPV.TabIndex = 6;
            groupBoxFilt_YPV.TabStop = false;
            groupBoxFilt_YPV.Text = "Выбор категории:";
            // 
            // comboBoxFilt_YPV
            // 
            comboBoxFilt_YPV.FormattingEnabled = true;
            comboBoxFilt_YPV.Items.AddRange(new object[] { "Яблоки", "Груши", "Бананы", "Огурцы", "Киви", "Лимоны", "Апельсины", "Все" });
            comboBoxFilt_YPV.Location = new Point(21, 86);
            comboBoxFilt_YPV.Name = "comboBoxFilt_YPV";
            comboBoxFilt_YPV.Size = new Size(485, 46);
            comboBoxFilt_YPV.TabIndex = 0;
            comboBoxFilt_YPV.SelectedIndexChanged += comboBoxFilt_YPV_SelectedIndexChanged_1;
            // 
            // groupBoxSort_YPV
            // 
            groupBoxSort_YPV.Controls.Add(comboBoxSort_YPV);
            groupBoxSort_YPV.Font = new Font("Microsoft Sans Serif", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxSort_YPV.Location = new Point(579, 20);
            groupBoxSort_YPV.Name = "groupBoxSort_YPV";
            groupBoxSort_YPV.Size = new Size(520, 167);
            groupBoxSort_YPV.TabIndex = 7;
            groupBoxSort_YPV.TabStop = false;
            groupBoxSort_YPV.Text = "Сортировка по количеству";
            // 
            // comboBoxSort_YPV
            // 
            comboBoxSort_YPV.FormattingEnabled = true;
            comboBoxSort_YPV.Items.AddRange(new object[] { "Max", "Min", "All" });
            comboBoxSort_YPV.Location = new Point(15, 83);
            comboBoxSort_YPV.Name = "comboBoxSort_YPV";
            comboBoxSort_YPV.Size = new Size(494, 46);
            comboBoxSort_YPV.TabIndex = 0;
            comboBoxSort_YPV.SelectedIndexChanged += comboBoxSort_YPV_SelectedIndexChanged;
            // 
            // buttonSum_YPV
            // 
            buttonSum_YPV.BackColor = Color.PowderBlue;
            buttonSum_YPV.Cursor = Cursors.Hand;
            buttonSum_YPV.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSum_YPV.ForeColor = SystemColors.MenuHighlight;
            buttonSum_YPV.Location = new Point(19, 36);
            buttonSum_YPV.Name = "buttonSum_YPV";
            buttonSum_YPV.Size = new Size(434, 124);
            buttonSum_YPV.TabIndex = 8;
            buttonSum_YPV.Text = "Количество продуктов на складе";
            toolTip_YPV.SetToolTip(buttonSum_YPV, "Посчитать количество всех продуктов на складе");
            buttonSum_YPV.UseVisualStyleBackColor = false;
            buttonSum_YPV.Click += buttonSum_YPV_Click;
            // 
            // buttonAverage_YPV
            // 
            buttonAverage_YPV.BackColor = Color.PowderBlue;
            buttonAverage_YPV.Cursor = Cursors.Hand;
            buttonAverage_YPV.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAverage_YPV.ForeColor = SystemColors.MenuHighlight;
            buttonAverage_YPV.Location = new Point(19, 187);
            buttonAverage_YPV.Name = "buttonAverage_YPV";
            buttonAverage_YPV.Size = new Size(440, 112);
            buttonAverage_YPV.TabIndex = 9;
            buttonAverage_YPV.Text = "Средняя цена";
            toolTip_YPV.SetToolTip(buttonAverage_YPV, "Посчитать среднюю цену за 1кг продукта");
            buttonAverage_YPV.UseVisualStyleBackColor = false;
            buttonAverage_YPV.Click += buttonAverage_YPV_Click;
            // 
            // buttonMin_YPV
            // 
            buttonMin_YPV.BackColor = Color.PowderBlue;
            buttonMin_YPV.Cursor = Cursors.Hand;
            buttonMin_YPV.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMin_YPV.ForeColor = SystemColors.MenuHighlight;
            buttonMin_YPV.Location = new Point(19, 323);
            buttonMin_YPV.Name = "buttonMin_YPV";
            buttonMin_YPV.Size = new Size(440, 80);
            buttonMin_YPV.TabIndex = 10;
            buttonMin_YPV.Text = "Минимальная цена";
            toolTip_YPV.SetToolTip(buttonMin_YPV, "Посчитать минимальную цену");
            buttonMin_YPV.UseVisualStyleBackColor = false;
            buttonMin_YPV.Click += buttonMin_YPV_Click;
            // 
            // buttonMax_YPV
            // 
            buttonMax_YPV.BackColor = Color.PowderBlue;
            buttonMax_YPV.Cursor = Cursors.Hand;
            buttonMax_YPV.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMax_YPV.ForeColor = SystemColors.MenuHighlight;
            buttonMax_YPV.Location = new Point(19, 434);
            buttonMax_YPV.Name = "buttonMax_YPV";
            buttonMax_YPV.Size = new Size(440, 80);
            buttonMax_YPV.TabIndex = 11;
            buttonMax_YPV.Text = "Максимальная цена";
            toolTip_YPV.SetToolTip(buttonMax_YPV, "Посчитать максимальную цену");
            buttonMax_YPV.UseVisualStyleBackColor = false;
            buttonMax_YPV.Click += buttonMax_YPV_Click;
            // 
            // textBoxSum_YPV
            // 
            textBoxSum_YPV.Location = new Point(500, 47);
            textBoxSum_YPV.Multiline = true;
            textBoxSum_YPV.Name = "textBoxSum_YPV";
            textBoxSum_YPV.ReadOnly = true;
            textBoxSum_YPV.Size = new Size(579, 89);
            textBoxSum_YPV.TabIndex = 12;
            // 
            // textBoxAverage_YPV
            // 
            textBoxAverage_YPV.Location = new Point(500, 187);
            textBoxAverage_YPV.Multiline = true;
            textBoxAverage_YPV.Name = "textBoxAverage_YPV";
            textBoxAverage_YPV.ReadOnly = true;
            textBoxAverage_YPV.Size = new Size(579, 89);
            textBoxAverage_YPV.TabIndex = 13;
            // 
            // textBoxMin_YPV
            // 
            textBoxMin_YPV.Location = new Point(500, 323);
            textBoxMin_YPV.Multiline = true;
            textBoxMin_YPV.Name = "textBoxMin_YPV";
            textBoxMin_YPV.ReadOnly = true;
            textBoxMin_YPV.Size = new Size(586, 70);
            textBoxMin_YPV.TabIndex = 14;
            // 
            // textBoxMax_YPV
            // 
            textBoxMax_YPV.Location = new Point(500, 449);
            textBoxMax_YPV.Multiline = true;
            textBoxMax_YPV.Name = "textBoxMax_YPV";
            textBoxMax_YPV.ReadOnly = true;
            textBoxMax_YPV.Size = new Size(586, 63);
            textBoxMax_YPV.TabIndex = 15;
            // 
            // buttonChart_YPV
            // 
            buttonChart_YPV.BackColor = Color.PowderBlue;
            buttonChart_YPV.Cursor = Cursors.Hand;
            buttonChart_YPV.Font = new Font("Microsoft Sans Serif", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonChart_YPV.ForeColor = SystemColors.MenuHighlight;
            buttonChart_YPV.Location = new Point(19, 560);
            buttonChart_YPV.Name = "buttonChart_YPV";
            buttonChart_YPV.Size = new Size(1067, 117);
            buttonChart_YPV.TabIndex = 16;
            buttonChart_YPV.Text = "Построить график стоимости";
            toolTip_YPV.SetToolTip(buttonChart_YPV, "Перейти и построить график");
            buttonChart_YPV.UseVisualStyleBackColor = false;
            buttonChart_YPV.Click += buttonChart_YPV_Click;
            // 
            // buttonSuppliers_YPV
            // 
            buttonSuppliers_YPV.BackColor = Color.PowderBlue;
            buttonSuppliers_YPV.Cursor = Cursors.Hand;
            buttonSuppliers_YPV.Font = new Font("Microsoft Sans Serif", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSuppliers_YPV.ForeColor = SystemColors.MenuHighlight;
            buttonSuppliers_YPV.Location = new Point(19, 711);
            buttonSuppliers_YPV.Name = "buttonSuppliers_YPV";
            buttonSuppliers_YPV.Size = new Size(1067, 99);
            buttonSuppliers_YPV.TabIndex = 17;
            buttonSuppliers_YPV.Text = "Информация о поставщиках";
            toolTip_YPV.SetToolTip(buttonSuppliers_YPV, "Перейти и получить информацию о поставщиках");
            buttonSuppliers_YPV.UseVisualStyleBackColor = false;
            buttonSuppliers_YPV.Click += buttonSuppliers_YPV_Click;
            // 
            // toolTip_YPV
            // 
            toolTip_YPV.ToolTipTitle = "Подсказка";
            // 
            // buttonSave_YPV
            // 
            buttonSave_YPV.Cursor = Cursors.Hand;
            buttonSave_YPV.Image = (Image)resources.GetObject("buttonSave_YPV.Image");
            buttonSave_YPV.Location = new Point(1494, 448);
            buttonSave_YPV.Name = "buttonSave_YPV";
            buttonSave_YPV.Size = new Size(214, 159);
            buttonSave_YPV.TabIndex = 3;
            toolTip_YPV.SetToolTip(buttonSave_YPV, "Сохранить данные");
            buttonSave_YPV.UseVisualStyleBackColor = true;
            buttonSave_YPV.Click += buttonSave_YPV_Click;
            // 
            // buttonOpen_YPV
            // 
            buttonOpen_YPV.Cursor = Cursors.Hand;
            buttonOpen_YPV.Image = (Image)resources.GetObject("buttonOpen_YPV.Image");
            buttonOpen_YPV.Location = new Point(1494, 254);
            buttonOpen_YPV.Name = "buttonOpen_YPV";
            buttonOpen_YPV.Size = new Size(214, 151);
            buttonOpen_YPV.TabIndex = 2;
            toolTip_YPV.SetToolTip(buttonOpen_YPV, "Загрузить файл");
            buttonOpen_YPV.UseVisualStyleBackColor = true;
            buttonOpen_YPV.Click += buttonOpen_YPV_Click;
            // 
            // openFileDialogMain_YPV
            // 
            openFileDialogMain_YPV.FileName = "openFileDialog1";
            // 
            // panelSearch_YPV
            // 
            panelSearch_YPV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelSearch_YPV.Controls.Add(labelSearch_YPV);
            panelSearch_YPV.Controls.Add(textBoxSearch_YPV);
            panelSearch_YPV.Location = new Point(1774, 254);
            panelSearch_YPV.Name = "panelSearch_YPV";
            panelSearch_YPV.Size = new Size(1081, 113);
            panelSearch_YPV.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(groupBoxFilt_YPV);
            panel2.Controls.Add(groupBoxSort_YPV);
            panel2.Location = new Point(1774, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 187);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(buttonSum_YPV);
            panel3.Controls.Add(textBoxSum_YPV);
            panel3.Controls.Add(buttonAverage_YPV);
            panel3.Controls.Add(textBoxAverage_YPV);
            panel3.Controls.Add(buttonMin_YPV);
            panel3.Controls.Add(buttonSuppliers_YPV);
            panel3.Controls.Add(textBoxMin_YPV);
            panel3.Controls.Add(buttonChart_YPV);
            panel3.Controls.Add(buttonMax_YPV);
            panel3.Controls.Add(textBoxMax_YPV);
            panel3.Location = new Point(1776, 627);
            panel3.Name = "panel3";
            panel3.Size = new Size(1109, 854);
            panel3.TabIndex = 20;
            // 
            // FormMain_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2885, 1480);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonSave_YPV);
            Controls.Add(buttonOpen_YPV);
            Controls.Add(panelSearch_YPV);
            Controls.Add(panel1);
            Controls.Add(panelTop_YPV);
            Name = "FormMain_YPV";
            StartPosition = FormStartPosition.CenterScreen;
            panelTop_YPV.ResumeLayout(false);
            panelTop_YPV.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_YPV).EndInit();
            groupBoxFilt_YPV.ResumeLayout(false);
            groupBoxSort_YPV.ResumeLayout(false);
            panelSearch_YPV.ResumeLayout(false);
            panelSearch_YPV.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_YPV;
        private Label labelName_YPV;
        private Panel panel1;
        private DataGridView dataGridViewMain_YPV;
        private Label labelSearch_YPV;
        private TextBox textBoxSearch_YPV;
        private Button buttonHelp_YPV;
        private Button buttonInfo_YPV;
        private GroupBox groupBoxFilt_YPV;
        private GroupBox groupBoxSort_YPV;
        private ComboBox comboBoxFilt_YPV;
        private ComboBox comboBoxSort_YPV;
        private Button buttonSum_YPV;
        private Button buttonAverage_YPV;
        private Button buttonMin_YPV;
        private Button buttonMax_YPV;
        private TextBox textBoxSum_YPV;
        private TextBox textBoxAverage_YPV;
        private TextBox textBoxMin_YPV;
        private TextBox textBoxMax_YPV;
        private Button buttonChart_YPV;
        private Button buttonSuppliers_YPV;
        private ToolTip toolTip_YPV;
        private OpenFileDialog openFileDialogMain_YPV;
        private SaveFileDialog saveFileDialogMain_YPV;
        private Panel panelSearch_YPV;
        private Button buttonSave_YPV;
        private Button buttonOpen_YPV;
        private Panel panel2;
        private Panel panel3;
    }
}
