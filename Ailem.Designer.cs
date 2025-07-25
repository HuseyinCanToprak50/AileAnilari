namespace AileAnilari
{
    partial class Ailem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ailem));
            lbl_baslik = new Label();
            aileKoduOlustur = new Button();
            label2 = new Label();
            txt_grupKodu = new TextBox();
            groupBox1 = new GroupBox();
            aileGrubaKatil = new Button();
            label3 = new Label();
            label1 = new Label();
            lbl_GrupKodu = new Label();
            flp_Ailem = new FlowLayoutPanel();
            lbl_GrupAdi = new Label();
            label4 = new Label();
            aileGruplariniListele = new Button();
            btn_gruptanCik = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_baslik
            // 
            lbl_baslik.AutoSize = true;
            lbl_baslik.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_baslik.Location = new Point(517, 18);
            lbl_baslik.Name = "lbl_baslik";
            lbl_baslik.Size = new Size(130, 52);
            lbl_baslik.TabIndex = 0;
            lbl_baslik.Text = "AİLEM";
            // 
            // aileKoduOlustur
            // 
            aileKoduOlustur.FlatStyle = FlatStyle.Flat;
            aileKoduOlustur.Image = (Image)resources.GetObject("aileKoduOlustur.Image");
            aileKoduOlustur.ImageAlign = ContentAlignment.MiddleLeft;
            aileKoduOlustur.Location = new Point(202, 374);
            aileKoduOlustur.Name = "aileKoduOlustur";
            aileKoduOlustur.Size = new Size(230, 69);
            aileKoduOlustur.TabIndex = 1;
            aileKoduOlustur.Text = "Aile Kodu Oluştur";
            aileKoduOlustur.UseVisualStyleBackColor = true;
            aileKoduOlustur.Click += aileKoduOlustur_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(240, 69);
            label2.Name = "label2";
            label2.Size = new Size(136, 35);
            label2.TabIndex = 2;
            label2.Text = "Aileye Katıl";
            // 
            // txt_grupKodu
            // 
            txt_grupKodu.BackColor = Color.FromArgb(240, 228, 215);
            txt_grupKodu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_grupKodu.Location = new Point(50, 145);
            txt_grupKodu.Multiline = true;
            txt_grupKodu.Name = "txt_grupKodu";
            txt_grupKodu.PlaceholderText = "Grup Kodunu Girin";
            txt_grupKodu.Size = new Size(446, 51);
            txt_grupKodu.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(240, 228, 215);
            groupBox1.Controls.Add(aileGrubaKatil);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(aileKoduOlustur);
            groupBox1.Controls.Add(txt_grupKodu);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkGoldenrod;
            groupBox1.Location = new Point(282, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 543);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aile Grubu Oluştur veya Katıl";
            // 
            // aileGrubaKatil
            // 
            aileGrubaKatil.FlatStyle = FlatStyle.Flat;
            aileGrubaKatil.Image = (Image)resources.GetObject("aileGrubaKatil.Image");
            aileGrubaKatil.ImageAlign = ContentAlignment.MiddleLeft;
            aileGrubaKatil.Location = new Point(502, 145);
            aileGrubaKatil.Name = "aileGrubaKatil";
            aileGrubaKatil.Size = new Size(119, 51);
            aileGrubaKatil.TabIndex = 5;
            aileGrubaKatil.Text = "Katıl";
            aileGrubaKatil.UseVisualStyleBackColor = true;
            aileGrubaKatil.Click += aileGrubaKatil_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(186, 302);
            label3.Name = "label3";
            label3.Size = new Size(246, 35);
            label3.TabIndex = 4;
            label3.Text = "Aile Grubun Yok Mu?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(920, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 5;
            label1.Text = "Grup Kodu:";
            // 
            // lbl_GrupKodu
            // 
            lbl_GrupKodu.AutoSize = true;
            lbl_GrupKodu.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_GrupKodu.Location = new Point(1048, 9);
            lbl_GrupKodu.Name = "lbl_GrupKodu";
            lbl_GrupKodu.Size = new Size(0, 30);
            lbl_GrupKodu.TabIndex = 6;
            // 
            // flp_Ailem
            // 
            flp_Ailem.AutoScroll = true;
            flp_Ailem.BackColor = Color.Transparent;
            flp_Ailem.Location = new Point(54, 224);
            flp_Ailem.Name = "flp_Ailem";
            flp_Ailem.Size = new Size(157, 77);
            flp_Ailem.TabIndex = 7;
            // 
            // lbl_GrupAdi
            // 
            lbl_GrupAdi.AutoSize = true;
            lbl_GrupAdi.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_GrupAdi.Location = new Point(122, 18);
            lbl_GrupAdi.Name = "lbl_GrupAdi";
            lbl_GrupAdi.Size = new Size(79, 30);
            lbl_GrupAdi.TabIndex = 8;
            lbl_GrupAdi.Text = "grpAdi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(104, 30);
            label4.TabIndex = 9;
            label4.Text = "Grup Adı:";
            // 
            // aileGruplariniListele
            // 
            aileGruplariniListele.FlatStyle = FlatStyle.Flat;
            aileGruplariniListele.Image = (Image)resources.GetObject("aileGruplariniListele.Image");
            aileGruplariniListele.ImageAlign = ContentAlignment.MiddleLeft;
            aileGruplariniListele.Location = new Point(678, 8);
            aileGruplariniListele.Name = "aileGruplariniListele";
            aileGruplariniListele.Size = new Size(236, 40);
            aileGruplariniListele.TabIndex = 10;
            aileGruplariniListele.Text = "Aile Gruplarını Listele";
            aileGruplariniListele.UseVisualStyleBackColor = true;
            aileGruplariniListele.Click += aileGruplariniListele_Click;
            // 
            // btn_gruptanCik
            // 
            btn_gruptanCik.FlatStyle = FlatStyle.Flat;
            btn_gruptanCik.Image = (Image)resources.GetObject("btn_gruptanCik.Image");
            btn_gruptanCik.ImageAlign = ContentAlignment.MiddleLeft;
            btn_gruptanCik.Location = new Point(331, 12);
            btn_gruptanCik.Name = "btn_gruptanCik";
            btn_gruptanCik.Size = new Size(180, 41);
            btn_gruptanCik.TabIndex = 11;
            btn_gruptanCik.Text = "Gruptan Çık";
            btn_gruptanCik.UseVisualStyleBackColor = true;
            btn_gruptanCik.Visible = false;
            btn_gruptanCik.Click += btn_gruptanCik_Click;
            // 
            // Ailem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(1281, 678);
            Controls.Add(btn_gruptanCik);
            Controls.Add(aileGruplariniListele);
            Controls.Add(label4);
            Controls.Add(lbl_GrupAdi);
            Controls.Add(flp_Ailem);
            Controls.Add(lbl_GrupKodu);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(lbl_baslik);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ailem";
            Text = "Ailem";
            Load += Ailem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_baslik;
        private Button aileKoduOlustur;
        private Label label2;
        private TextBox txt_grupKodu;
        private GroupBox groupBox1;
        private Button aileGrubaKatil;
        private Label label3;
        private Label label1;
        private Label lbl_kod;
        private FlowLayoutPanel flp_Ailem;
        public Label lbl_GrupKodu;
        private Label lbl_GrupAdi;
        private Label label4;
        private Button aileGruplariniListele;
        private Button btn_gruptanCik;
    }
}