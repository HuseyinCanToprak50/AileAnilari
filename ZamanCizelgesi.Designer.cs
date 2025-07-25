namespace AileAnilari
{
    partial class ZamanCizelgesi
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
            flp_Anilar = new FlowLayoutPanel();
            label1 = new Label();
            lbl_grupKodu = new Label();
            label2 = new Label();
            txt_AniAra = new TextBox();
            SuspendLayout();
            // 
            // flp_Anilar
            // 
            flp_Anilar.AutoScroll = true;
            flp_Anilar.BackColor = Color.FromArgb(240, 228, 215);
            flp_Anilar.ForeColor = Color.Black;
            flp_Anilar.Location = new Point(2, 113);
            flp_Anilar.Name = "flp_Anilar";
            flp_Anilar.Size = new Size(1267, 563);
            flp_Anilar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1059, 26);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "Grup Kodu:";
            // 
            // lbl_grupKodu
            // 
            lbl_grupKodu.AutoSize = true;
            lbl_grupKodu.ForeColor = Color.Black;
            lbl_grupKodu.Location = new Point(1148, 26);
            lbl_grupKodu.Name = "lbl_grupKodu";
            lbl_grupKodu.Size = new Size(83, 20);
            lbl_grupKodu.TabIndex = 2;
            lbl_grupKodu.Text = "Grup Kodu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 9);
            label2.Name = "label2";
            label2.Size = new Size(175, 35);
            label2.TabIndex = 3;
            label2.Text = "Ailemin Anıları";
            // 
            // txt_AniAra
            // 
            txt_AniAra.BackColor = Color.FromArgb(240, 228, 215);
            txt_AniAra.BorderStyle = BorderStyle.FixedSingle;
            txt_AniAra.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AniAra.Location = new Point(339, 12);
            txt_AniAra.Name = "txt_AniAra";
            txt_AniAra.PlaceholderText = "Anılarıda Ara 🔍";
            txt_AniAra.Size = new Size(511, 36);
            txt_AniAra.TabIndex = 4;
            txt_AniAra.TextChanged += txt_AniAra_TextChanged;
            // 
            // ZamanCizelgesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(1281, 678);
            Controls.Add(txt_AniAra);
            Controls.Add(label2);
            Controls.Add(lbl_grupKodu);
            Controls.Add(label1);
            Controls.Add(flp_Anilar);
            ForeColor = Color.FromArgb(240, 228, 215);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ZamanCizelgesi";
            Text = "ZamanCizelgesi";
            Load += ZamanCizelgesi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_Anilar;
        private Label label1;
        private Label lbl_grupKodu;
        private Label label2;
        private TextBox txt_AniAra;
    }
}