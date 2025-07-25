namespace AileAnilari
{
    partial class Kategoriler
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
            txt_kategoriAdi = new TextBox();
            btnKategoriEkle = new Button();
            flp_kategoriler = new FlowLayoutPanel();
            txt_arama = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(74, 55, 40);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(205, 47);
            label1.TabIndex = 0;
            label1.Text = "Kategoriler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 77);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 1;
            label2.Text = "Yeni Kategori Ekle";
            // 
            // txt_kategoriAdi
            // 
            txt_kategoriAdi.BackColor = Color.FromArgb(240, 228, 215);
            txt_kategoriAdi.BorderStyle = BorderStyle.FixedSingle;
            txt_kategoriAdi.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_kategoriAdi.Location = new Point(25, 123);
            txt_kategoriAdi.Name = "txt_kategoriAdi";
            txt_kategoriAdi.PlaceholderText = "Kategori adı";
            txt_kategoriAdi.Size = new Size(933, 36);
            txt_kategoriAdi.TabIndex = 2;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.BackColor = Color.FromArgb(240, 228, 215);
            btnKategoriEkle.FlatStyle = FlatStyle.Flat;
            btnKategoriEkle.ForeColor = Color.FromArgb(74, 55, 40);
            btnKategoriEkle.Location = new Point(25, 175);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(93, 43);
            btnKategoriEkle.TabIndex = 3;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = false;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // flp_kategoriler
            // 
            flp_kategoriler.AutoScroll = true;
            flp_kategoriler.Location = new Point(12, 248);
            flp_kategoriler.Name = "flp_kategoriler";
            flp_kategoriler.Size = new Size(1257, 418);
            flp_kategoriler.TabIndex = 4;
            // 
            // txt_arama
            // 
            txt_arama.BackColor = Color.FromArgb(240, 228, 215);
            txt_arama.BorderStyle = BorderStyle.FixedSingle;
            txt_arama.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_arama.Location = new Point(738, 12);
            txt_arama.Name = "txt_arama";
            txt_arama.PlaceholderText = "Kategorilerde Ara 🔍";
            txt_arama.Size = new Size(531, 36);
            txt_arama.TabIndex = 5;
            txt_arama.TextChanged += txt_arama_TextChanged;
            // 
            // Kategoriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(1281, 678);
            Controls.Add(txt_arama);
            Controls.Add(flp_kategoriler);
            Controls.Add(btnKategoriEkle);
            Controls.Add(txt_kategoriAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kategoriler";
            Text = "Kategoriler";
            Load += Kategoriler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_kategoriAdi;
        private Button btnKategoriEkle;
        private FlowLayoutPanel flp_kategoriler;
        private TextBox txt_arama;
    }
}