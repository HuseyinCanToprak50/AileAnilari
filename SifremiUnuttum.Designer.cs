namespace AileAnilari
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            btn_mailGonder = new Button();
            txt_mail = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            lbl_baslik = new Label();
            btn_kucult = new Button();
            btn_kapat = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_mailGonder
            // 
            btn_mailGonder.FlatStyle = FlatStyle.Flat;
            btn_mailGonder.Location = new Point(235, 215);
            btn_mailGonder.Name = "btn_mailGonder";
            btn_mailGonder.Size = new Size(187, 49);
            btn_mailGonder.TabIndex = 0;
            btn_mailGonder.Text = "E-Posta Gönder";
            btn_mailGonder.UseVisualStyleBackColor = true;
            btn_mailGonder.Click += btn_mailGonder_Click;
            // 
            // txt_mail
            // 
            txt_mail.BackColor = SystemColors.Control;
            txt_mail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mail.ForeColor = SystemColors.MenuText;
            txt_mail.Location = new Point(160, 149);
            txt_mail.Multiline = true;
            txt_mail.Name = "txt_mail";
            txt_mail.PlaceholderText = "E-posta giriniz";
            txt_mail.Size = new Size(330, 38);
            txt_mail.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_baslik);
            panel1.Controls.Add(btn_kucult);
            panel1.Controls.Add(btn_kapat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 50);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(246, 14);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 6;
            label1.Text = "-Şifremi Unuttum-";
            // 
            // lbl_baslik
            // 
            lbl_baslik.AutoSize = true;
            lbl_baslik.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_baslik.ForeColor = SystemColors.Control;
            lbl_baslik.Location = new Point(12, 14);
            lbl_baslik.Name = "lbl_baslik";
            lbl_baslik.Size = new Size(133, 22);
            lbl_baslik.TabIndex = 5;
            lbl_baslik.Text = "Aile Anı Arşivi";
            // 
            // btn_kucult
            // 
            btn_kucult.BackColor = Color.Transparent;
            btn_kucult.FlatStyle = FlatStyle.Flat;
            btn_kucult.ForeColor = Color.SandyBrown;
            btn_kucult.Image = (Image)resources.GetObject("btn_kucult.Image");
            btn_kucult.Location = new Point(568, 3);
            btn_kucult.Name = "btn_kucult";
            btn_kucult.Size = new Size(41, 44);
            btn_kucult.TabIndex = 4;
            btn_kucult.UseVisualStyleBackColor = false;
            btn_kucult.Click += btn_kucult_Click;
            // 
            // btn_kapat
            // 
            btn_kapat.BackColor = Color.Transparent;
            btn_kapat.FlatStyle = FlatStyle.Flat;
            btn_kapat.ForeColor = Color.SandyBrown;
            btn_kapat.Image = (Image)resources.GetObject("btn_kapat.Image");
            btn_kapat.Location = new Point(615, 3);
            btn_kapat.Name = "btn_kapat";
            btn_kapat.Size = new Size(41, 44);
            btn_kapat.TabIndex = 3;
            btn_kapat.UseVisualStyleBackColor = false;
            btn_kapat.Click += btn_kapat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(659, 320);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(txt_mail);
            Controls.Add(btn_mailGonder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SifremiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifremiUnuttum";
            MouseDown += SifremiUnuttum_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mailGonder;
        private TextBox txt_mail;
        private Panel panel1;
        private Button btn_kapat;
        private Button btn_kucult;
        private Label label1;
        private Label lbl_baslik;
        private PictureBox pictureBox1;
    }
}