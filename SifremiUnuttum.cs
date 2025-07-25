using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AileAnilari
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        public static string GenerateRandomPassword(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_mailGonder_Click(object sender, EventArgs e)
        {
            string mail = txt_mail.Text;

            using (AileAnilariDbContext context = new AileAnilariDbContext())
            {
                var kullaniciSifre = context.Kullanicilar.FirstOrDefault(eposta => eposta.Mail == mail);
                if (kullaniciSifre != null)
                {
                    string yeniSifre = GenerateRandomPassword(10);
                    kullaniciSifre.Sifre = yeniSifre;
                    context.SaveChanges();

                    SendEmail(mail, yeniSifre);
                    MessageBox.Show("Yeni Şifreniz Mailinize Gönderilmiştir! Lütfen Güvenliğiniz İçin Şifrenizi Değiştirmeyi Unutmayın", "Mail Gönderimi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{mail} E-postası bulunamadı ");
                }
            }
        }

        private void SendEmail(string toEmail, string newPassword)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(Environment.GetEnvironmentVariable("EMAIL_USER"));
                mail.To.Add(toEmail);
                mail.Subject = "Şifre Sıfırlama";
                mail.Body = $"Merhaba, \nyeni şifreniz: {newPassword}\nLütfen giriş yaptıktan sonra şifrenizi değiştirin.";

                smtpServer.Port = 587;

                string emailUser = Environment.GetEnvironmentVariable("EMAIL_USER");
                string emailPass = Environment.GetEnvironmentVariable("EMAIL_PASS");

                smtpServer.Credentials = new NetworkCredential(emailUser, emailPass);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SifremiUnuttum_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Capture = false;
                Message msg = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                DefWndProc(ref msg);
            }
        }
    }
}
