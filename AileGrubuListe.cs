using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AileAnilari
{
    public partial class AileGrubuListe : Form
    {
        public AileGrubuListe()
        {
            InitializeComponent();
        }


        private void AileGrubuListe_Load(object sender, EventArgs e)
        {
            // DataGridView kontrolüne modern stil uygulamak için metodu çağırır
            StyleModernDataGridView(data_UyeListe);

            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // AileGrubu tablosundan ID, grup adı ve kodu seçer, anonim nesne oluşturur ve listeye dönüştürür
            var aileGrupları = context.AileGrubu.Select(a => new
            {
                a.AileGrubuID,
                a.GrupAdi,
                a.GrupKodu
            }).ToList();
            // Oluşturulan listeyi DataGridView'in veri kaynağı olarak atar
            data_UyeListe.DataSource = aileGrupları;
        }



        private void StyleModernDataGridView(DataGridView dgv)
        {
            // Genel stil
            dgv.BackgroundColor = Color.FromArgb(240, 228, 215);
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.GridColor = Color.LightGray;

            // Font ve metin rengi
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(190, 170, 150);  // seçili satır arkaplanı
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternatif satır renkleri
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 245, 235); // açık ton
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // Başlık tasarımı
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(210, 198, 185);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 35;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Satır yüksekliği
            dgv.RowTemplate.Height = 30;

            // Otomatik sütun genişliği
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
