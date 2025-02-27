namespace Assignment_7._1_Final_Project_UI
{
    partial class Form2
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
            label1 = new Label();
            comboBoxType = new ComboBox();
            textBoxenter = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(248, 22);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 0;
            label1.Text = "User Type";
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Segoe UI", 15F);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Admin", "User" });
            comboBoxType.Location = new Point(88, 80);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(391, 36);
            comboBoxType.TabIndex = 1;
            // 
            // textBoxenter
            // 
            textBoxenter.Font = new Font("Segoe UI", 15F);
            textBoxenter.Location = new Point(88, 191);
            textBoxenter.Name = "textBoxenter";
            textBoxenter.Size = new Size(391, 34);
            textBoxenter.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(267, 135);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 3;
            label2.Text = "User";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(192, 252);
            button1.Name = "button1";
            button1.Size = new Size(197, 41);
            button1.TabIndex = 4;
            button1.Text = "Check Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(601, 345);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBoxenter);
            Controls.Add(comboBoxType);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxType;
        private TextBox textBoxenter;
        private Label label2;
        private Button button1;
    }
}