namespace Assignment_7._1_Final_Project_UI
{
    partial class Form1
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
            labelnumber = new Label();
            textBoxnumber = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // labelnumber
            // 
            labelnumber.AutoSize = true;
            labelnumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            labelnumber.Location = new Point(224, 56);
            labelnumber.Name = "labelnumber";
            labelnumber.Size = new Size(169, 28);
            labelnumber.TabIndex = 0;
            labelnumber.Text = "Enter un nomber";
            labelnumber.Click += labelnumber_Click;
            // 
            // textBoxnumber
            // 
            textBoxnumber.Font = new Font("Segoe UI", 12F);
            textBoxnumber.Location = new Point(109, 111);
            textBoxnumber.Name = "textBoxnumber";
            textBoxnumber.Size = new Size(404, 29);
            textBoxnumber.TabIndex = 1;
            // 
            // button
            // 
            button.BackColor = Color.Lime;
            button.Font = new Font("Segoe UI", 12F);
            button.ForeColor = SystemColors.ActiveCaptionText;
            button.Location = new Point(224, 180);
            button.Name = "button";
            button.Size = new Size(169, 36);
            button.TabIndex = 2;
            button.Text = "Multiplication Table";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(607, 340);
            Controls.Add(button);
            Controls.Add(textBoxnumber);
            Controls.Add(labelnumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnumber;
        private TextBox textBoxnumber;
        private Button button;
    }
}
