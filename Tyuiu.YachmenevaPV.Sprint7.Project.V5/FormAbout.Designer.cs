namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5
{
    partial class FormAbout_YPV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_YPV));
            labelAbout_YPV = new Label();
            buttonOkAbout_YPV = new Button();
            SuspendLayout();
            // 
            // labelAbout_YPV
            // 
            labelAbout_YPV.AutoSize = true;
            labelAbout_YPV.Location = new Point(22, 28);
            labelAbout_YPV.Name = "labelAbout_YPV";
            labelAbout_YPV.Size = new Size(774, 451);
            labelAbout_YPV.TabIndex = 0;
            labelAbout_YPV.Text = resources.GetString("labelAbout_YPV.Text");
            // 
            // buttonOkAbout_YPV
            // 
            buttonOkAbout_YPV.FlatStyle = FlatStyle.Flat;
            buttonOkAbout_YPV.Location = new Point(871, 395);
            buttonOkAbout_YPV.Name = "buttonOkAbout_YPV";
            buttonOkAbout_YPV.Size = new Size(188, 58);
            buttonOkAbout_YPV.TabIndex = 1;
            buttonOkAbout_YPV.Text = "OK";
            buttonOkAbout_YPV.UseVisualStyleBackColor = true;
            buttonOkAbout_YPV.Click += buttonOkAbout_YPV_Click;
            // 
            // FormAbout_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 498);
            Controls.Add(buttonOkAbout_YPV);
            Controls.Add(labelAbout_YPV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAbout_YPV";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout_YPV;
        private Button buttonOkAbout_YPV;
    }
}