namespace AileAnilari
{
    partial class AileGrubuListe
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
            data_UyeListe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)data_UyeListe).BeginInit();
            SuspendLayout();
            // 
            // data_UyeListe
            // 
            data_UyeListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_UyeListe.Dock = DockStyle.Fill;
            data_UyeListe.Location = new Point(0, 0);
            data_UyeListe.Name = "data_UyeListe";
            data_UyeListe.RowHeadersWidth = 51;
            data_UyeListe.RowTemplate.Height = 29;
            data_UyeListe.Size = new Size(884, 497);
            data_UyeListe.TabIndex = 0;
            // 
            // AileGrubuListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 228, 215);
            ClientSize = new Size(884, 497);
            Controls.Add(data_UyeListe);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AileGrubuListe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AileGrubuListe";
            Load += AileGrubuListe_Load;
            ((System.ComponentModel.ISupportInitialize)data_UyeListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_UyeListe;
    }
}