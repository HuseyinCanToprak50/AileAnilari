namespace AileAnilari
{
    partial class KayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            panel1 = new Panel();
            btn_kucult = new Button();
            btn_kapat = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_kullaniciAdi = new TextBox();
            txt_eposta = new TextBox();
            txt_sifre = new TextBox();
            txt_sifreTekrar = new TextBox();
            btn_kaydet = new Button();
            label3 = new Label();
            link_GirisYap = new LinkLabel();
            checkBox1 = new CheckBox();
            combo_Rol = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(btn_kucult);
            panel1.Controls.Add(btn_kapat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 50);
            panel1.TabIndex = 0;
            // 
            // btn_kucult
            // 
            btn_kucult.FlatStyle = FlatStyle.Flat;
            btn_kucult.ForeColor = Color.Peru;
            btn_kucult.Image = (Image)resources.GetObject("btn_kucult.Image");
            btn_kucult.Location = new Point(897, 9);
            btn_kucult.Name = "btn_kucult";
            btn_kucult.Size = new Size(35, 32);
            btn_kucult.TabIndex = 2;
            btn_kucult.UseVisualStyleBackColor = true;
            btn_kucult.Click += btn_kucult_Click;
            // 
            // btn_kapat
            // 
            btn_kapat.FlatStyle = FlatStyle.Flat;
            btn_kapat.ForeColor = Color.Peru;
            btn_kapat.Image = (Image)resources.GetObject("btn_kapat.Image");
            btn_kapat.Location = new Point(937, 3);
            btn_kapat.Name = "btn_kapat";
            btn_kapat.Size = new Size(39, 44);
            btn_kapat.TabIndex = 1;
            btn_kapat.UseVisualStyleBackColor = true;
            btn_kapat.Click += btn_kapat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(428, 14);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 1;
            label2.Text = "-KAYIT OL-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 0;
            label1.Text = "Aile Anı Arşivi";
            // 
            // txt_kullaniciAdi
            // 
            txt_kullaniciAdi.BackColor = SystemColors.Info;
            txt_kullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_kullaniciAdi.Location = new Point(334, 148);
            txt_kullaniciAdi.Multiline = true;
            txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            txt_kullaniciAdi.PlaceholderText = "Adı Soyadı";
            txt_kullaniciAdi.Size = new Size(325, 44);
            txt_kullaniciAdi.TabIndex = 1;
            // 
            // txt_eposta
            // 
            txt_eposta.BackColor = SystemColors.Info;
            txt_eposta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_eposta.Location = new Point(334, 262);
            txt_eposta.Multiline = true;
            txt_eposta.Name = "txt_eposta";
            txt_eposta.PlaceholderText = "E-Posta";
            txt_eposta.Size = new Size(325, 44);
            txt_eposta.TabIndex = 2;
            // 
            // txt_sifre
            // 
            txt_sifre.BackColor = SystemColors.Info;
            txt_sifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sifre.Location = new Point(334, 321);
            txt_sifre.Multiline = true;
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.PlaceholderText = "Şifre";
            txt_sifre.Size = new Size(325, 44);
            txt_sifre.TabIndex = 3;
            // 
            // txt_sifreTekrar
            // 
            txt_sifreTekrar.BackColor = SystemColors.Info;
            txt_sifreTekrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sifreTekrar.Location = new Point(334, 379);
            txt_sifreTekrar.Multiline = true;
            txt_sifreTekrar.Name = "txt_sifreTekrar";
            txt_sifreTekrar.PasswordChar = '*';
            txt_sifreTekrar.PlaceholderText = "Şifre Tekrar";
            txt_sifreTekrar.Size = new Size(325, 44);
            txt_sifreTekrar.TabIndex = 4;
            // 
            // btn_kaydet
            // 
            btn_kaydet.BackColor = Color.Transparent;
            btn_kaydet.FlatStyle = FlatStyle.Flat;
            btn_kaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_kaydet.ForeColor = SystemColors.ControlLightLight;
            btn_kaydet.Location = new Point(361, 438);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(279, 65);
            btn_kaydet.TabIndex = 5;
            btn_kaydet.Text = "Kayıt Ol";
            btn_kaydet.UseVisualStyleBackColor = false;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(420, 520);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 6;
            label3.Text = "Hesabın var mı?";
            // 
            // link_GirisYap
            // 
            link_GirisYap.AutoSize = true;
            link_GirisYap.BackColor = Color.Transparent;
            link_GirisYap.LinkColor = Color.White;
            link_GirisYap.Location = new Point(531, 520);
            link_GirisYap.Name = "link_GirisYap";
            link_GirisYap.Size = new Size(66, 20);
            link_GirisYap.TabIndex = 7;
            link_GirisYap.TabStop = true;
            link_GirisYap.Text = "Giriş Yap";
            link_GirisYap.LinkClicked += link_GirisYap_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(665, 330);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Şifre Göster";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // combo_Rol
            // 
            combo_Rol.BackColor = SystemColors.Info;
            combo_Rol.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            combo_Rol.ForeColor = Color.Gray;
            combo_Rol.FormattingEnabled = true;
            combo_Rol.Items.AddRange(new object[] { "Anne", "Baba", "Çocuk", "Kardeş", "Abi", "Abla", "Dede", "Nine", "Hala", "Teyze", "Amca", "Dayı", "Kuzen", "Gelin", "Damat", "Kayınvalide", "Kayınpeder", "Eş", "Torun" });
            combo_Rol.Location = new Point(334, 209);
            combo_Rol.Name = "combo_Rol";
            combo_Rol.Size = new Size(325, 38);
            combo_Rol.TabIndex = 9;
            combo_Rol.Text = "Rol Seçin...";
            // 
            // KayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(988, 626);
            Controls.Add(combo_Rol);
            Controls.Add(checkBox1);
            Controls.Add(link_GirisYap);
            Controls.Add(label3);
            Controls.Add(btn_kaydet);
            Controls.Add(txt_sifreTekrar);
            Controls.Add(txt_sifre);
            Controls.Add(txt_eposta);
            Controls.Add(txt_kullaniciAdi);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayitOl";
            MouseDown += KayitOl_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btn_kapat;
        private Button btn_kucult;
        private TextBox txt_kullaniciAdi;
        private TextBox txt_eposta;
        private TextBox txt_sifre;
        private TextBox txt_sifreTekrar;
        private Button btn_kaydet;
        private Label label3;
        private LinkLabel link_GirisYap;
        private CheckBox checkBox1;
        private ComboBox combo_Rol;
    }
}