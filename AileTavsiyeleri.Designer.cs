namespace AileAnilari
{
    partial class AileTavsiyeleri
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
            txtTavsiyeBaslik = new TextBox();
            label2 = new Label();
            txtTavsiyeIcerik = new TextBox();
            btnTavsiyeEkle = new Button();
            flp_tavsiyeler = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Tavsiye Başlığı:";
            // 
            // txtTavsiyeBaslik
            // 
            txtTavsiyeBaslik.BackColor = Color.FromArgb(240, 228, 215);
            txtTavsiyeBaslik.BorderStyle = BorderStyle.FixedSingle;
            txtTavsiyeBaslik.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTavsiyeBaslik.Location = new Point(161, 27);
            txtTavsiyeBaslik.Margin = new Padding(4, 5, 4, 5);
            txtTavsiyeBaslik.Multiline = true;
            txtTavsiyeBaslik.Name = "txtTavsiyeBaslik";
            txtTavsiyeBaslik.Size = new Size(505, 40);
            txtTavsiyeBaslik.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Tavsiye İçerik:";
            // 
            // txtTavsiyeIcerik
            // 
            txtTavsiyeIcerik.BackColor = Color.FromArgb(240, 228, 215);
            txtTavsiyeIcerik.BorderStyle = BorderStyle.FixedSingle;
            txtTavsiyeIcerik.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTavsiyeIcerik.Location = new Point(161, 89);
            txtTavsiyeIcerik.Margin = new Padding(4, 5, 4, 5);
            txtTavsiyeIcerik.Multiline = true;
            txtTavsiyeIcerik.Name = "txtTavsiyeIcerik";
            txtTavsiyeIcerik.Size = new Size(631, 226);
            txtTavsiyeIcerik.TabIndex = 3;
            // 
            // btnTavsiyeEkle
            // 
            btnTavsiyeEkle.FlatStyle = FlatStyle.Flat;
            btnTavsiyeEkle.Location = new Point(649, 325);
            btnTavsiyeEkle.Margin = new Padding(4, 5, 4, 5);
            btnTavsiyeEkle.Name = "btnTavsiyeEkle";
            btnTavsiyeEkle.Size = new Size(143, 47);
            btnTavsiyeEkle.TabIndex = 6;
            btnTavsiyeEkle.Text = "Tavsiye Ekle";
            btnTavsiyeEkle.UseVisualStyleBackColor = true;
            btnTavsiyeEkle.Click += btnTavsiyeEkle_Click;
            // 
            // flp_tavsiyeler
            // 
            flp_tavsiyeler.AutoScroll = true;
            flp_tavsiyeler.Location = new Point(12, 388);
            flp_tavsiyeler.Name = "flp_tavsiyeler";
            flp_tavsiyeler.Size = new Size(1244, 278);
            flp_tavsiyeler.TabIndex = 7;
            // 
            // AileTavsiyeleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(1281, 678);
            Controls.Add(flp_tavsiyeler);
            Controls.Add(btnTavsiyeEkle);
            Controls.Add(txtTavsiyeIcerik);
            Controls.Add(label2);
            Controls.Add(txtTavsiyeBaslik);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AileTavsiyeleri";
            Text = "Yeni Tavsiye Ekle";
            Load += AileTavsiyeleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTavsiyeBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTavsiyeIcerik;
        private System.Windows.Forms.Button btnTavsiyeEkle;
        private FlowLayoutPanel flp_tavsiyeler;
    }
}