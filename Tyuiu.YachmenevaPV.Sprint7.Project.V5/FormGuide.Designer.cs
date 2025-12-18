namespace Tyuiu.YachmenevaPV.Sprint7.Project.V5
{
    partial class FormGuide_YPV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide_YPV));
            label1 = new Label();
            buttonOkGuide_YPV = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(1379, 1025);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonOkGuide_YPV
            // 
            buttonOkGuide_YPV.BackColor = SystemColors.ActiveCaption;
            buttonOkGuide_YPV.FlatStyle = FlatStyle.Flat;
            buttonOkGuide_YPV.Location = new Point(1188, 1069);
            buttonOkGuide_YPV.Name = "buttonOkGuide_YPV";
            buttonOkGuide_YPV.Size = new Size(188, 79);
            buttonOkGuide_YPV.TabIndex = 1;
            buttonOkGuide_YPV.Text = "OK";
            buttonOkGuide_YPV.UseVisualStyleBackColor = false;
            buttonOkGuide_YPV.Click += buttonOkGuide_YPV_Click;
            // 
            // FormGuide_YPV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1183);
            Controls.Add(buttonOkGuide_YPV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGuide_YPV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOkGuide_YPV;
    }
}