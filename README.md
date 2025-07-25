# 📚 Aile Anıları – Aile Büyüklerinden Anı Toplama ve Arşivleme Uygulaması

## 🧭 Proje Tanıtımı
**Aile Anıları**, kullanıcıların kendi yaşamlarından veya aile büyüklerinden topladıkları yazılı anılar, ses kayıtları, fotoğraflar, videolar ve belgeleri **kronolojik, kategorik ve dijital şekilde arşivleyebileceği** bir masaüstü uygulamasıdır.

Uygulama, bireylerin kültürel geçmişlerini dijital ortamda güvenli ve kalıcı şekilde saklamasını ve gelecek nesillere aktarmasını hedefler.

> Bu proje, Gazi Üniversitesi BİL204 - Yazılım Mimarileri dersi kapsamında bireysel olarak geliştirilmiştir.

---

## 🛠️ Kullanılan Teknolojiler

| Bileşen                | Teknoloji                          |
|------------------------|------------------------------------|
| Programlama Dili       | C# (.NET Framework)                |
| Arayüz                 | Windows Forms                      |
| Veritabanı             | SQLite                             |
| ORM                    | Entity Framework Core (Code First) |
| Ses Entegrasyonu       | NAudio                             |
| E-posta Bildirimi      | Gmail SMTP                         |
| Mimarisi               | Katmanlı Mimari (UI-BLL-DAL)       |
| Yazılım Süreci         | Agile (Çevik Model) – 5 Sprint     |

---

## 🔍 Özellikler

### 👤 Kullanıcı Yönetimi
- Kayıt, giriş ve şifre sıfırlama
- Profil oluşturma ve güncelleme
- Aile grubuna katılma/oluşturma

### 📌 Anı & Medya Ekleme
- Yazılı, sesli, görsel ve video anı ekleme
- Anıya başlık, açıklama, tarih, yer, kategori iliştirme

### 🕰️ Zaman Çizelgesi
- Anıların tarihsel olarak otomatik sıralanması
- Anıları anı başlıklarına göre filtreleme

### 🗂️ Kategorilendirme
- Kendi kategorilerini oluşturma ve düzenleme
- Etiket bazlı arama ve filtreleme

### 🔍 Arama & Görselleştirme
- Anahtar kelime, kişi, tarih bazlı hızlı arama
- Galeri görünümü (fotoğraf & video)
- Sade yazı görünümü (anı metinleri)

### 👨‍👩‍👧‍👦 Aile Grubu Sistemi
- Grup oluşturma, gruba katılım
- Grup içi anıların zaman çizelgesinde listelenmesi
- Üyelerin profil kartları ve detaylı görünüm

### 💬 Tavsiye Modülü
- Aile büyüklerinden gelen öneri ve hayat derslerinin arşivlenmesi

---

## 🧩 Yazılım Mimarisi

Proje, **katmanlı mimari** ile geliştirilmiştir:

- `Entity Layer` → Veri modelleri  
- `DAL` → Entity Framework Code First ile veri işlemleri  
- `BLL` → İş kuralları ve kontroller  
- `UI` → Windows Forms arayüz

🔄 **UserController** yapısı ile kullanıcı işlemleri (oturum yönetimi, grup filtreleme, erişim) dinamik olarak yönetilir.

---

## 🧪 Geliştirme Süreci (Çevik Model)

| Sprint | İçerik                                                 |
|--------|--------------------------------------------------------|
| 1      | Kullanıcı yönetimi (giriş/kayıt/profil)                |
| 2      | Anı ve medya yükleme                                   |
| 3      | Zaman çizelgesi ve kategori sistemi                    |
| 4      | Aile grubu oluşturma ve katılım                        |
| 5      | Arama, filtreleme ve raporlama                         |



