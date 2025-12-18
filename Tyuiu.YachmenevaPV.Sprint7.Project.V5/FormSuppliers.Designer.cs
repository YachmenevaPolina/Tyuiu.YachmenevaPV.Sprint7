namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5
{
    partial class FormSuppliers_YPV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuppliers_YPV));
            panelTopSuppliers_YPV = new Panel();
            buttonBackSuppliers_YPV = new Button();
            labelNameSuppliers_YPV = new Label();
            dataGridViewSuppliers_YPV = new DataGridView();
            buttonOpenSuppliers_YPV = new Button();
            buttonSuppliersSave_YPV = new Button();
            buttonAddSuppliers_YPV = new Button();
            buttonDelete_YPV = new Button();
            groupBoxFiltSuppliers_YPV = new GroupBox();
            comboBoxFiltSuppliers_YPV = new ComboBox();
            openFileDialogSuppliers_YPV = new OpenFileDialog();
            toolTipSuppliers_YPV = new ToolTip(components);
            saveFileDialogSuppliers_YPV = new SaveFileDialog();
            panelTopSuppliers_YPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_YPV).BeginInit();
            groupBoxFiltSuppliers_YPV.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopSuppliers_YPV
            // 
            panelTopSuppliers_YPV.BackColor = Color.PowderBlue;
            panelTopSuppliers_YPV.Controls.Add(buttonBackSuppliers_YPV);
            panelTopSuppliers_YPV.Controls.Add(labelNameSuppliers_YPV);
            panelTopSuppliers_YPV.Dock = DockStyle.Top;
            panelTopSuppliers_YPV.Location = new Point(0, 0);
            panelTopSuppliers_YPV.Name = "panelTopSuppliers_YPV";
            panelTopSuppliers_YPV.Size = new Size(2843, 227);
            panelTopSuppliers_YPV.TabIndex = 0;
            // 
            // buttonBackSuppliers_YPV
            // 
            buttonBackSuppliers_YPV.Image = (Image)resources.GetObject("buttonBackSuppliers_YPV.Image");
            buttonBackSuppliers_YPV.Location = new Point(60, 56);
            buttonBackSuppliers_YPV.Name = "buttonBackSuppliers_YPV";
            buttonBackSuppliers_YPV.Size = new Size(188, 121);
            buttonBackSuppliers_YPV.TabIndex = 1;
            buttonBackSuppliers_YPV.UseVisualStyleBackColor = true;
            buttonBackSuppliers_YPV.Click += buttonBackSuppliers_YPV_Click;
            // 
            // labelNameSuppliers_YPV
            // 
            labelNameSuppliers_YPV.Anchor = AnchorStyles.Top;
            labelNameSuppliers_YPV.AutoSize = true;
            labelNameSuppliers_YPV.Font = new Font("Microsoft Sans Serif", 26.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNameSuppliers_YPV.Location = new Point(693, 68);
            labelNameSuppliers_YPV.Name = "labelNameSuppliers_YPV";
            labelNameSuppliers_YPV.Size = new Size(1504, 98);
            labelNameSuppliers_YPV.TabIndex = 0;
            labelNameSuppliers_YPV.Text = "ИНФОРМАЦИЯ О ПОСТАВЩИКАХ";
            // 
            // dataGridViewSuppliers_YPV
            // 
            dataGridViewSuppliers_YPV.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewSuppliers_YPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers_YPV.Dock = DockStyle.Left;
            dataGridViewSuppliers_YPV.Location = new Point(0, 227);
            dataGridViewSuppliers_YPV.Name = "dataGridViewSuppliers_YPV";
            dataGridViewSuppliers_YPV.RowHeadersVisible = false;
            dataGridViewSuppliers_YPV.RowHeadersWidth = 102;
            dataGridViewSuppliers_YPV.ScrollBars = ScrollBars.Vertical;
            dataGridViewSuppliers_YPV.Size = new Size(1588, 1090);
            dataGridViewSuppliers_YPV.TabIndex = 5;
            // 
            // buttonOpenSuppliers_YPV
            // 
            buttonOpenSuppliers_YPV.Cursor = Cursors.Hand;
            buttonOpenSuppliers_YPV.Image = (Image)resources.GetObject("buttonOpenSuppliers_YPV.Image");
            buttonOpenSuppliers_YPV.Location = new Point(1641, 251);
            buttonOpenSuppliers_YPV.Name = "buttonOpenSuppliers_YPV";
            buttonOpenSuppliers_YPV.Size = new Size(207, 142);
            buttonOpenSuppliers_YPV.TabIndex = 6;
            toolTipSuppliers_YPV.SetToolTip(buttonOpenSuppliers_YPV, "Загрузить данные");
            buttonOpenSuppliers_YPV.UseVisualStyleBackColor = true;
            buttonOpenSuppliers_YPV.Click += buttonOpenSuppliers_YPV_Click;
            // 
            // buttonSuppliersSave_YPV
            // 
            buttonSuppliersSave_YPV.Cursor = Cursors.Hand;
            buttonSuppliersSave_YPV.Image = (Image)resources.GetObject("buttonSuppliersSave_YPV.Image");
            buttonSuppliersSave_YPV.Location = new Point(1641, 431);
            buttonSuppliersSave_YPV.Name = "buttonSuppliersSave_YPV";
            buttonSuppliersSave_YPV.Size = new Size(207, 142);
            buttonSuppliersSave_YPV.TabIndex = 7;
            buttonSuppliersSave_YPV.UseVisualStyleBackColor = true;
            buttonSuppliersSave_YPV.Click += buttonSuppliersSave_YPV_Click;
            // 
            // buttonAddSuppliers_YPV
            // 
            buttonAddSuppliers_YPV.Image = (Image)resources.GetObject("buttonAddSuppliers_YPV.Image");
            buttonAddSuppliers_YPV.Location = new Point(1641, 611);
            buttonAddSuppliers_YPV.Name = "buttonAddSuppliers_YPV";
            buttonAddSuppliers_YPV.Size = new Size(207, 142);
            buttonAddSuppliers_YPV.TabIndex = 8;
            buttonAddSuppliers_YPV.UseVisualStyleBackColor = true;
            buttonAddSuppliers_YPV.Click += buttonAddSuppliers_YPV_Click;
            // 
            // buttonDelete_YPV
            // 
            buttonDelete_YPV.Image = (Image)resources.GetObject("buttonDelete_YPV.Image");
            buttonDelete_YPV.Location = new Point(1641, 788);
            buttonDelete_YPV.Name = "buttonDelete_YPV";
            buttonDelete_YPV.Size = new Size(207, 142);
            buttonDelete_YPV.TabIndex = 9;
            buttonDelete_YPV.UseVisualStyleBackColor = true;
            buttonDelete_YPV.Click += buttonDelete_YPV_Click;
            // 
            // groupBoxFiltSuppliers_YPV
            // 
            groupBoxFiltSuppliers_YPV.Controls.Add(comboBoxFiltSuppliers_YPV);
            groupBoxFiltSuppliers_YPV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxFiltSuppliers_YPV.Location = new Point(1641, 977);
            groupBoxFiltSuppliers_YPV.Name = "groupBoxFiltSuppliers_YPV";
            groupBoxFiltSuppliers_YPV.Size = new Size(1157, 250);
            groupBoxFiltSuppliers_YPV.TabIndex = 10;
            groupBoxFiltSuppliers_YPV.TabStop = false;
            groupBoxFiltSuppliers_YPV.Text = "Фильтр по месяцу поставки";
            // 
            // comboBoxFiltSuppliers_YPV
            // 
            comboBoxFiltSuppliers_YPV.FormattingEnabled = true;
            comboBoxFiltSuppliers_YPV.Items.AddRange(new object[] { "Декабрь", "Январь", "Февраль", "Все" });
            comboBoxFiltSuppliers_YPV.Location = new Point(23, 111);
            comboBoxFiltSuppliers_YPV.Name = "comboBoxFiltSuppliers_YPV";
            comboBoxFiltSuppliers_YPV.Size = new Size(1104, 54);
            comboBoxFiltSuppliers_YPV.TabIndex = 0;
            comboBoxFiltSuppliers_YPV.SelectedIndexChanged += comboBoxFiltSuppliers_YPV_SelectedIndexChanged;
            // 
            // openFileDialogSuppliers_YPV
            // 
            openFileDialogSuppliers_YPV.FileName = "openFileDialog1";
            // 
            // toolTipSuppliers_YPV
            // 
            toolTipSuppliers_YPV.ToolTipTitle = "Подсказка";
            // 
            // FormSuppliers_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2843, 1317);
            Controls.Add(groupBoxFiltSuppliers_YPV);
            Controls.Add(buttonDelete_YPV);
            Controls.Add(buttonAddSuppliers_YPV);
            Controls.Add(buttonSuppliersSave_YPV);
            Controls.Add(buttonOpenSuppliers_YPV);
            Controls.Add(dataGridViewSuppliers_YPV);
            Controls.Add(panelTopSuppliers_YPV);
            ForeColor = SystemColors.MenuHighlight;
            Name = "FormSuppliers_YPV";
            Text = "О поставщиках";
            panelTopSuppliers_YPV.ResumeLayout(false);
            panelTopSuppliers_YPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_YPV).EndInit();
            groupBoxFiltSuppliers_YPV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopSuppliers_YPV;
        private Label labelNameSuppliers_YPV;
        private Button buttonBackSuppliers_YPV;
        private DataGridView dataGridViewSuppliers_YPV;
        private Button buttonOpenSuppliers_YPV;
        private Button buttonSuppliersSave_YPV;
        private Button buttonAddSuppliers_YPV;
        private Button buttonDelete_YPV;
        private GroupBox groupBoxFiltSuppliers_YPV;
        private ComboBox comboBoxFiltSuppliers_YPV;
        private ToolTip toolTipSuppliers_YPV;
        private OpenFileDialog openFileDialogSuppliers_YPV;
        private SaveFileDialog saveFileDialogSuppliers_YPV;
    }
}