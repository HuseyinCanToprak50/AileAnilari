namespace AileAnilari
{
    partial class Hakkında
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(46, 200);
            label1.Name = "label1";
            label1.Size = new Size(287, 72);
            label1.TabIndex = 0;
            label1.Text = "Hazırlayan:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 32F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(350, 191);
            label2.Name = "label2";
            label2.Size = new Size(536, 72);
            label2.TabIndex = 1;
            label2.Text = "Hüseyin Can TOPRAK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 32F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(46, 75);
            label3.Name = "label3";
            label3.Size = new Size(276, 72);
            label3.TabIndex = 2;
            label3.Text = "Proje İsmi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 32F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(339, 75);
            label4.Name = "label4";
            label4.Size = new Size(287, 72);
            label4.TabIndex = 3;
            label4.Text = "Aile Anıları";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 32F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(57, 321);
            label5.Name = "label5";
            label5.Size = new Size(245, 72);
            label5.TabIndex = 4;
            label5.Text = "Versiyon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 32F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(339, 321);
            label6.Name = "label6";
            label6.Size = new Size(100, 72);
            label6.TabIndex = 5;
            label6.Text = "1.0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 32F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(307, 449);
            label7.Name = "label7";
            label7.Size = new Size(597, 72);
            label7.TabIndex = 7;
            label7.Text = "hcan.toprak@gazi.edu.tr";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 32F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(57, 449);
            label8.Name = "label8";
            label8.Size = new Size(211, 72);
            label8.TabIndex = 6;
            label8.Text = "İletişim:";
            // 
            // Hakkında
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(1281, 678);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hakkında";
            Text = "Hakkında";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}