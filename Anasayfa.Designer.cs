namespace AileAnilari
{
    partial class Anasayfa
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
            lbl_isim = new Label();
            flp_Anilar = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txt_AniAra = new TextBox();
            SuspendLayout();
            // 
            // lbl_isim
            // 
            lbl_isim.AutoSize = true;
            lbl_isim.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_isim.Location = new Point(1039, 24);
            lbl_isim.Name = "lbl_isim";
            lbl_isim.Size = new Size(138, 35);
            lbl_isim.TabIndex = 0;
            lbl_isim.Text = "isimSoyisim";
            // 
            // flp_Anilar
            // 
            flp_Anilar.AutoScroll = true;
            flp_Anilar.Location = new Point(2, 103);
            flp_Anilar.Name = "flp_Anilar";
            flp_Anilar.Size = new Size(1267, 563);
            flp_Anilar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(885, 24);
            label1.Name = "label1";
            label1.Size = new Size(139, 35);
            label1.TabIndex = 2;
            label1.Text = "Hoşgeldiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(107, 35);
            label2.TabIndex = 3;
            label2.Text = "Anılarım";
            // 
            // txt_AniAra
            // 
            txt_AniAra.BackColor = Color.FromArgb(240, 228, 215);
            txt_AniAra.BorderStyle = BorderStyle.FixedSingle;
            txt_AniAra.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AniAra.Location = new Point(273, 24);
            txt_AniAra.Name = "txt_AniAra";
            txt_AniAra.PlaceholderText = "  Anılarımda Ara 🔍";
            txt_AniAra.Size = new Size(514, 36);
            txt_AniAra.TabIndex = 4;
            txt_AniAra.TextChanged += txt_AniAra_TextChanged;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(1281, 678);
            Controls.Add(txt_AniAra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flp_Anilar);
            Controls.Add(lbl_isim);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Anasayfa";
            Text = "Anasayfa";
            Load += Anasayfa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_isim;
        private FlowLayoutPanel flp_Anilar;
        private Label label1;
        private Label label2;
        private TextBox txt_AniAra;
    }
}