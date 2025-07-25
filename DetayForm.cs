using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AileAnilari;
using AxWMPLib;
using Microsoft.EntityFrameworkCore;
using AileAnilari.UserControls;

namespace AileAnilari
{
    public partial class DetayForm : Form
    {
        private readonly int _anıID; // Anının ID'sini tutan değişken

        public DetayForm(int anıID)
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
            // Parametre olarak gelen anı ID'sini sınıf değişkenine atar
            _anıID = anıID;
        }

        private void DetayForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde anı içeriğini yükler
            YukleIcerik(_anıID);
        }

        private void YukleIcerik(int anıID)
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Anıyı, kategori ve medya bilgileriyle birlikte veritabanından çeker
            var ani = context.Anilar
                .Include(a => a.Kategori)
                .Include(a => a.Medyalar)
                .FirstOrDefault(a => a.AnıID == anıID);
            // Medya yollarını türlerine göre ayırır
            var resimYollari = ani.Medyalar.Where(m => m.MedyaTuru == "Resim").Select(m => m.DosyaYolu).ToList();
            var videoYollari = ani.Medyalar.Where(m => m.MedyaTuru == "Video").Select(m => m.DosyaYolu).ToList();
            var sesYollari = ani.Medyalar.Where(m => m.MedyaTuru == "Ses").Select(m => m.DosyaYolu).ToList();
            var belgeYollari = ani.Medyalar.Where(m => m.MedyaTuru == "Belge").Select(m => m.DosyaYolu).ToList();

            // FlowLayoutPanel'deki mevcut kontrolleri temizler
            flowLayoutPanel1.Controls.Clear();

            // Başlık etiketi oluşturur
            Label lblBaslik = new Label
            {
                Text = ani.Baslik,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(10)
            };
            flowLayoutPanel1.Controls.Add(lblBaslik);

            // Açıklama etiketi oluşturur
            Label lblAciklama = new Label
            {
                Text = ani.Icerik,
                MaximumSize = new Size(flowLayoutPanel1.Width - 40, 0),
                AutoSize = true,
                Margin = new Padding(10)
            };
            flowLayoutPanel1.Controls.Add(lblAciklama);

            // Fotoğraflar için yeni bir FlowLayoutPanel oluşturur
            FlowLayoutPanel flpFotolar = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,   // İçeriklerin sarılmasını sağlar
                AutoSize = true,
                Width = flowLayoutPanel1.Width - 20,  // Genişlik ayarı
                Height = 300,
                Margin = new Padding(10)
            };

            // Resimleri yükler
            foreach (var resimYolu in resimYollari)
            {
                if (File.Exists(resimYolu))
                {
                    PictureBox pic = new PictureBox
                    {
                        Image = Image.FromFile(resimYolu),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 400,
                        Height = 250,
                        Margin = new Padding(10)
                    };
                    // Resme tıklandığında dosyayı varsayılan uygulamayla açar
                    pic.Click += (s, e) =>
                    {
                        Process.Start(new ProcessStartInfo()
                        {
                            FileName = resimYolu,
                            UseShellExecute = true,
                        });
                    };
                    flpFotolar.Controls.Add(pic);
                }
            }
            flowLayoutPanel1.Controls.Add(flpFotolar);

            // Videoları yükler
            foreach (var videoYolu in videoYollari)
            {
                Button btnVideo = new Button();
                btnVideo.Text = System.IO.Path.GetFileName(videoYolu); // Dosya adını gösterir
                btnVideo.Width = 400;
                btnVideo.Height = 30;
                btnVideo.Tag = videoYolu; // Dosya yolunu Tag'de saklar
                btnVideo.Click += (s, e) =>
                {
                    string yol = (s as Button).Tag.ToString();
                    // Videoyu varsayılan uygulamayla açar
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = yol,
                        UseShellExecute = true
                    });
                };
                flowLayoutPanel1.Controls.Add(btnVideo);
            }

            // Ses dosyalarını yükler
            foreach (var sesYolu in sesYollari)
            {
                if (File.Exists(sesYolu))
                {
                    Button btnSes = new Button();
                    btnSes.Text = System.IO.Path.GetFileName(sesYolu);
                    btnSes.Width = 400;
                    btnSes.Height = 30;
                    btnSes.Tag = sesYolu;
                    btnSes.Click += (s, e) =>
                    {
                        string yol = (s as Button).Tag.ToString();
                        // Ses dosyasını varsayılan uygulamayla açar
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = yol,
                            UseShellExecute = true
                        });
                    };
                    flowLayoutPanel1.Controls.Add(btnSes);
                }
            }

            // Belgeleri yükler
            foreach (var belgeYolu in belgeYollari)
            {
                if (File.Exists(belgeYolu))
                {
                    LinkLabel belgeLink = new LinkLabel
                    {
                        Text = Path.GetFileName(belgeYolu),
                        Tag = belgeYolu,
                        AutoSize = true,
                        Margin = new Padding(10)
                    };
                    // Belgeye tıklandığında dosyayı explorer ile açar
                    belgeLink.LinkClicked += (s, e) =>
                    {
                        Process.Start("explorer", "\"" + belgeYolu + "\"");
                    };
                    flowLayoutPanel1.Controls.Add(belgeLink);
                }
            }
        }

        public class AniModel
        {
            public string Baslik { get; set; } // Anının başlığı
            public string Aciklama { get; set; } // Anının açıklaması
            public DateTime Tarih { get; set; } // Anının tarihi
            public List<string> ResimYollari { get; set; } // Resim dosyalarının yolları
            public List<string> VideoYollari { get; set; } // Video dosyalarının yolları
            public List<string> SesYollari { get; set; } // Ses dosyalarının yolları
            public List<string> BelgeYollari { get; set; } // Belge dosyalarının yolları
        }
    }
}