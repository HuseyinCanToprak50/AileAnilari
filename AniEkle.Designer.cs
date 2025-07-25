namespace AileAnilari
{
    partial class AniEkle
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
            label_AniEkle = new Label();
            txt_aniBaslik = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_yer = new TextBox();
            txt_tarih = new MaskedTextBox();
            label6 = new Label();
            combo_kategori = new ComboBox();
            label7 = new Label();
            txt_aniAciklama = new RichTextBox();
            btn_medyaEkle = new Button();
            btn_aniEkle = new Button();
            listViewMedya = new ListView();
            SuspendLayout();
            // 
            // label_AniEkle
            // 
            label_AniEkle.AutoSize = true;
            label_AniEkle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label_AniEkle.ForeColor = Color.FromArgb(74, 55, 40);
            label_AniEkle.Location = new Point(40, 20);
            label_AniEkle.Name = "label_AniEkle";
            label_AniEkle.Size = new Size(186, 38);
            label_AniEkle.TabIndex = 0;
            label_AniEkle.Text = "Yeni Anı Ekle";
            // 
            // txt_aniBaslik
            // 
            txt_aniBaslik.BackColor = Color.FromArgb(240, 228, 215);
            txt_aniBaslik.BorderStyle = BorderStyle.FixedSingle;
            txt_aniBaslik.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_aniBaslik.ForeColor = Color.FromArgb(74, 55, 40);
            txt_aniBaslik.Location = new Point(40, 106);
            txt_aniBaslik.Multiline = true;
            txt_aniBaslik.Name = "txt_aniBaslik";
            txt_aniBaslik.ScrollBars = ScrollBars.Vertical;
            txt_aniBaslik.Size = new Size(422, 60);
            txt_aniBaslik.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(74, 55, 40);
            label2.Location = new Point(40, 73);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 2;
            label2.Text = "Anı Başlığı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(74, 55, 40);
            label3.Location = new Point(40, 191);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(74, 55, 40);
            label4.Location = new Point(40, 298);
            label4.Name = "label4";
            label4.Size = new Size(52, 30);
            label4.TabIndex = 6;
            label4.Text = "Yer:";
            // 
            // txt_yer
            // 
            txt_yer.BackColor = Color.FromArgb(240, 228, 215);
            txt_yer.BorderStyle = BorderStyle.FixedSingle;
            txt_yer.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_yer.ForeColor = Color.FromArgb(74, 55, 40);
            txt_yer.Location = new Point(40, 331);
            txt_yer.Multiline = true;
            txt_yer.Name = "txt_yer";
            txt_yer.ScrollBars = ScrollBars.Vertical;
            txt_yer.Size = new Size(439, 114);
            txt_yer.TabIndex = 5;
            // 
            // txt_tarih
            // 
            txt_tarih.BackColor = Color.FromArgb(240, 228, 215);
            txt_tarih.BorderStyle = BorderStyle.FixedSingle;
            txt_tarih.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tarih.ForeColor = Color.FromArgb(74, 55, 40);
            txt_tarih.Location = new Point(40, 224);
            txt_tarih.Mask = "00/00/0000";
            txt_tarih.Name = "txt_tarih";
            txt_tarih.Size = new Size(417, 36);
            txt_tarih.TabIndex = 9;
            txt_tarih.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(74, 55, 40);
            label6.Location = new Point(40, 478);
            label6.Name = "label6";
            label6.Size = new Size(108, 30);
            label6.TabIndex = 11;
            label6.Text = "Kategori:";
            // 
            // combo_kategori
            // 
            combo_kategori.BackColor = Color.FromArgb(240, 228, 215);
            combo_kategori.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            combo_kategori.FormattingEnabled = true;
            combo_kategori.Location = new Point(43, 523);
            combo_kategori.Name = "combo_kategori";
            combo_kategori.Size = new Size(419, 38);
            combo_kategori.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(74, 55, 40);
            label7.Location = new Point(558, 73);
            label7.Name = "label7";
            label7.Size = new Size(169, 30);
            label7.TabIndex = 13;
            label7.Text = "Anı Açıklaması:";
            // 
            // txt_aniAciklama
            // 
            txt_aniAciklama.BackColor = Color.FromArgb(240, 228, 215);
            txt_aniAciklama.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_aniAciklama.ForeColor = Color.FromArgb(74, 55, 40);
            txt_aniAciklama.Location = new Point(554, 110);
            txt_aniAciklama.Name = "txt_aniAciklama";
            txt_aniAciklama.ScrollBars = RichTextBoxScrollBars.Vertical;
            txt_aniAciklama.Size = new Size(701, 261);
            txt_aniAciklama.TabIndex = 14;
            txt_aniAciklama.Text = "";
            // 
            // btn_medyaEkle
            // 
            btn_medyaEkle.FlatStyle = FlatStyle.Flat;
            btn_medyaEkle.ForeColor = Color.FromArgb(74, 55, 40);
            btn_medyaEkle.Location = new Point(552, 399);
            btn_medyaEkle.Name = "btn_medyaEkle";
            btn_medyaEkle.Size = new Size(138, 32);
            btn_medyaEkle.TabIndex = 15;
            btn_medyaEkle.Text = "📎Medya Ekle ";
            btn_medyaEkle.UseVisualStyleBackColor = true;
            btn_medyaEkle.Click += btn_medyaEkle_Click;
            // 
            // btn_aniEkle
            // 
            btn_aniEkle.FlatStyle = FlatStyle.Flat;
            btn_aniEkle.ForeColor = Color.FromArgb(74, 55, 40);
            btn_aniEkle.Location = new Point(1063, 618);
            btn_aniEkle.Name = "btn_aniEkle";
            btn_aniEkle.Size = new Size(138, 32);
            btn_aniEkle.TabIndex = 17;
            btn_aniEkle.Text = "✒️ Anı Ekle";
            btn_aniEkle.UseVisualStyleBackColor = true;
            btn_aniEkle.Click += btn_aniEkle_Click;
            // 
            // listViewMedya
            // 
            listViewMedya.BackColor = Color.FromArgb(240, 228, 215);
            listViewMedya.Location = new Point(552, 437);
            listViewMedya.Name = "listViewMedya";
            listViewMedya.Size = new Size(663, 157);
            listViewMedya.TabIndex = 18;
            listViewMedya.UseCompatibleStateImageBehavior = false;
            listViewMedya.OwnerDraw = true;

            listViewMedya.View = View.Details;
            listViewMedya.FullRowSelect = true;
            listViewMedya.GridLines = true;

            listViewMedya.DrawColumnHeader += listViewMedya_DrawColumnHeader;
            listViewMedya.DrawSubItem += listViewMedya_DrawSubItem;
            listViewMedya.MouseClick += listViewMedya_MouseClick;
            // 
            // AniEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(1281, 678);
            Controls.Add(listViewMedya);
            Controls.Add(btn_aniEkle);
            Controls.Add(btn_medyaEkle);
            Controls.Add(txt_aniAciklama);
            Controls.Add(label7);
            Controls.Add(combo_kategori);
            Controls.Add(label6);
            Controls.Add(txt_tarih);
            Controls.Add(label4);
            Controls.Add(txt_yer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_aniBaslik);
            Controls.Add(label_AniEkle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AniEkle";
            Text = "Anasayfa";
            Load += AniEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_AniEkle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button btn_medyaEkle;
        private Button btn_aniEkle;
        public TextBox txt_aniBaslik;
        public TextBox txt_yer;
        public MaskedTextBox txt_tarih;
        public ComboBox combo_kategori;
        public RichTextBox txt_aniAciklama;
        public ListView listViewMedya;
    }
}