using AileAnilari.Model;
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
    public partial class AniEkle : Form
    {
        private string _kullaniciID; // Aktif kullanıcının ID'sini tutan değişken

        public AniEkle(string kullaniciID)
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
            // Parametre olarak gelen kullanıcı ID'sini sınıf değişkenine atar
            this._kullaniciID = kullaniciID;
        }

        private void AniEkle_Load(object sender, EventArgs e)
        {
            // Form yüklenirken ListView'in görünümünü detay moduna ayarlar
            listViewMedya.View = View.Details;
            // ListView'de tam satır seçimini etkinleştirir
            listViewMedya.FullRowSelect = true;
            // ListView'de ızgara çizgilerini gösterir
            listViewMedya.GridLines = true;

            // ListView'e sütun başlıklarını ekler
            listViewMedya.Columns.Add("Dosya Adı", 150);
            listViewMedya.Columns.Add("Tür", 100);
            listViewMedya.Columns.Add("Yol", 250);
            listViewMedya.Columns.Add("Uzantı", 75);
            listViewMedya.Columns.Add("Sil", 50);

            // Kategorileri veritabanından çeker ve ComboBox'a yükler
            KategorileriGetir();
        }

        private void btn_medyaEkle_Click(object sender, EventArgs e)
        {
            // Dosya seçimi için OpenFileDialog oluşturur
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Diyalog başlığını ayarlar
            openFileDialog.Title = "Medya Dosyası Seçin";
            // Desteklenen dosya türlerini filtreler
            openFileDialog.Filter = "Tüm Desteklenen Dosyalar|*.mp3;*.wav;*.mp4;*.avi;*.jpg;*.jpeg;*.png;*.gif;*.txt;*.pdf;*.doc;*.docx";
            // Birden fazla dosya seçimine izin verir
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen her dosya için döngü başlatır
                foreach (string yol in openFileDialog.FileNames)
                {
                    // Dosya adını alır
                    string ad = Path.GetFileName(yol);
                    // Dosya uzantısını küçük harfe çevirerek alır
                    string uzanti = Path.GetExtension(yol).ToLower();
                    string tur = "";
                    // Dosya uzantısına göre türünü belirler
                    if (new[] { ".mp3", ".wav" }.Contains(uzanti)) tur = "Ses";
                    else if (new[] { ".mp4", ".avi" }.Contains(uzanti)) tur = "Video";
                    else if (new[] { ".jpg", ".jpeg", ".png", ".gif" }.Contains(uzanti)) tur = "Resim";
                    else if (new[] { ".txt", ".pdf", ".doc", ".docx" }.Contains(uzanti)) tur = "Belge";
                    else tur = "Bilinmiyor";

                    // ListViewItem oluşturur ve bilgileri ekler
                    ListViewItem item = new ListViewItem(ad);
                    item.SubItems.Add(tur);
                    item.SubItems.Add(yol);
                    item.SubItems.Add(uzanti);
                    item.SubItems.Add("Sil");

                    // Ögeyi ListView'e ekler
                    listViewMedya.Items.Add(item);
                }
            }
        }

        private void btn_aniEkle_Click(object sender, EventArgs e)
        {
            bool bosAlanVar = false;

            // Formdaki tüm kontrolleri kontrol eder
            foreach (Control ctrl in this.Controls)
            {
                // Kontrol TextBox, ComboBox veya MaskedTextBox ise
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is MaskedTextBox)
                {
                    // Boş veya yalnızca boşluk içeriyorsa bayrağı true yapar
                    if (string.IsNullOrWhiteSpace(ctrl.Text))
                    {
                        bosAlanVar = true;
                        break;
                    }
                }

                // Kontrolün alt kontrolleri varsa onları da kontrol eder
                if (ctrl.HasChildren)
                {
                    foreach (Control child in ctrl.Controls)
                    {
                        if (child is TextBox || child is ComboBox || child is MaskedTextBox)
                        {
                            if (string.IsNullOrWhiteSpace(child.Text))
                            {
                                bosAlanVar = true;
                                break;
                            }
                        }
                    }
                }

                if (bosAlanVar) break;
            }

            // Boş alan varsa hata mesajı gösterir ve işlemi durdurur
            if (bosAlanVar)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Anı Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni anıyı ekler
            YeniAniEkle();
        }

        private void YeniAniEkle()
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Yeni bir Anilar nesnesi oluşturur ve formdan gelen verilerle doldurur
            Anilar yeniAni = new Anilar
            {
                Baslik = txt_aniBaslik.Text,
                Icerik = txt_aniAciklama.Text,
                Tarih = Convert.ToDateTime(txt_tarih.Text),
                Yer = txt_yer.Text,
                EkleyenKullaniciID = Convert.ToInt32(_kullaniciID),
                KategoriId = int.Parse(combo_kategori.SelectedValue.ToString()),
                Medyalar = new List<Medya>()
            };

            // ListView'deki her öge için bir Medya nesnesi oluşturur
            foreach (ListViewItem item in listViewMedya.Items)
            {
                Medya medya = new Medya()
                {
                    Aciklama = item.SubItems[0].Text,
                    MedyaTuru = item.SubItems[1].Text,
                    DosyaYolu = item.SubItems[2].Text
                };
                // Medya nesnesini anının Medyalar listesine ekler
                yeniAni.Medyalar.Add(medya);
            }
            // Yeni anıyı veritabanına ekler
            context.Anilar.Add(yeniAni);
            // Değişiklikleri veritabanına kaydeder
            context.SaveChanges();
            // Başarı mesajı gösterir
            MessageBox.Show("Anı Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KategorileriGetir()
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Tüm kategorileri veritabanından çeker
            var kategoriler = context.Kategori.ToList();
            // ComboBox'ın veri kaynağını kategorilere bağlar
            combo_kategori.DataSource = kategoriler;
            // ComboBox'ta görünecek özelliği KategoriAdi olarak ayarlar
            combo_kategori.DisplayMember = "KategoriAdi";
            // ComboBox'ta arka planda tutulacak değeri KategoriId olarak ayarlar
            combo_kategori.ValueMember = "KategoriId";
        }

        private void listViewMedya_MouseClick(object sender, MouseEventArgs e)
        {
            // Tıklanan ListView ögesini ve sütununu belirler
            ListViewHitTestInfo info = listViewMedya.HitTest(e.Location);
            ListViewItem item = info.Item;
            int sutunIndex = info.Item.SubItems.IndexOf(info.SubItem);

            // Öge varsa ve tıklanan sütun "Sil" (4. sütun) ise
            if (item != null && sutunIndex == 4)
            {
                // Silme onayı için diyalog gösterir
                DialogResult sonuc = MessageBox.Show("Bu öğe silinsin mi?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.Yes)
                {
                    // Onaylanırsa ögeyi ListView'den kaldırır
                    listViewMedya.Items.Remove(item);
                }
            }
        }

        private void listViewMedya_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Sütun başlıklarını varsayılan şekilde çizer
            e.DrawDefault = true;
        }

        private void listViewMedya_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Eğer çizilen sütun "Sil" (4. sütun) ise
            if (e.ColumnIndex == 4)
            {
                // Metni kırmızı renkte çizer
                e.Graphics.DrawString(e.SubItem.Text, listViewMedya.Font, Brushes.Red, e.Bounds);
            }
            else
            {
                // Diğer sütunları varsayılan şekilde çizer
                e.DrawDefault = true;
            }
        }
    }
}