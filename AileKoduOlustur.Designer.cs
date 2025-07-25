namespace AileAnilari
{
    partial class AileKoduOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AileKoduOlustur));
            txt_grupKodu = new TextBox();
            btn_GrupOlustur = new Button();
            label1 = new Label();
            txt_GrupAdi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_RastgeleKodOlustur = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_grupKodu
            // 
            txt_grupKodu.BackColor = Color.FromArgb(240, 228, 215);
            txt_grupKodu.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_grupKodu.Location = new Point(51, 249);
            txt_grupKodu.MaxLength = 10;
            txt_grupKodu.Multiline = true;
            txt_grupKodu.Name = "txt_grupKodu";
            txt_grupKodu.PlaceholderText = "Grup Kodu Girin";
            txt_grupKodu.Size = new Size(286, 42);
            txt_grupKodu.TabIndex = 0;
            // 
            // btn_GrupOlustur
            // 
            btn_GrupOlustur.FlatStyle = FlatStyle.Popup;
            btn_GrupOlustur.Image = (Image)resources.GetObject("btn_GrupOlustur.Image");
            btn_GrupOlustur.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GrupOlustur.Location = new Point(116, 444);
            btn_GrupOlustur.Name = "btn_GrupOlustur";
            btn_GrupOlustur.Size = new Size(171, 57);
            btn_GrupOlustur.TabIndex = 1;
            btn_GrupOlustur.Text = "Grup Oluştur";
            btn_GrupOlustur.UseVisualStyleBackColor = true;
            btn_GrupOlustur.Click += btn_GrupOlustur_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 2;
            label1.Text = "AİLE GRUBU OLUŞTUR";
            // 
            // txt_GrupAdi
            // 
            txt_GrupAdi.BackColor = Color.FromArgb(240, 228, 215);
            txt_GrupAdi.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_GrupAdi.Location = new Point(51, 168);
            txt_GrupAdi.Multiline = true;
            txt_GrupAdi.Name = "txt_GrupAdi";
            txt_GrupAdi.PlaceholderText = "Grup Adı";
            txt_GrupAdi.Size = new Size(286, 42);
            txt_GrupAdi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 135);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Grup Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 226);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 5;
            label3.Text = "Grup Kodu";
            // 
            // btn_RastgeleKodOlustur
            // 
            btn_RastgeleKodOlustur.FlatStyle = FlatStyle.Popup;
            btn_RastgeleKodOlustur.Image = (Image)resources.GetObject("btn_RastgeleKodOlustur.Image");
            btn_RastgeleKodOlustur.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RastgeleKodOlustur.Location = new Point(51, 318);
            btn_RastgeleKodOlustur.Name = "btn_RastgeleKodOlustur";
            btn_RastgeleKodOlustur.Size = new Size(286, 57);
            btn_RastgeleKodOlustur.TabIndex = 6;
            btn_RastgeleKodOlustur.Text = "Rastgele Kod Oluştur";
            btn_RastgeleKodOlustur.UseVisualStyleBackColor = true;
            btn_RastgeleKodOlustur.Click += btn_RastgeleKodOlustur_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // AileKoduOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(426, 527);
            Controls.Add(pictureBox1);
            Controls.Add(btn_RastgeleKodOlustur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_GrupAdi);
            Controls.Add(label1);
            Controls.Add(btn_GrupOlustur);
            Controls.Add(txt_grupKodu);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AileKoduOlustur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aile Kodu Oluştur";
            Load += AileKoduOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_grupKodu;
        private Button btn_GrupOlustur;
        private Label label1;
        private TextBox txt_GrupAdi;
        private Label label2;
        private Label label3;
        private Button btn_RastgeleKodOlustur;
        private PictureBox pictureBox1;
    }
}