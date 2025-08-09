
# 💰 Gelir Gider Takibi

Kullanıcıların aylık maaşlarını ve harcamalarını takip etmelerini sağlayan, kategorilere göre analizler sunan ve görsel grafiklerle desteklenen ASP.NET Core MVC tabanlı bir web uygulaması.

---

## 🚀 Özellikler

- **Aylık Maaş Takibi**: Kullanıcılar her ay için maaş bilgilerini kaydedebilir.
- **Harcama Ekleme & Kategorileme**: Harcamalar kategori bazlı olarak eklenebilir (Gıda, Ulaşım, Eğlence vb.).
- **Grafiksel Analiz**: Chart.js ile kategori dağılımları ve toplam harcama grafikleri.
- **Veri Doğrulama**: Formlarda zorunlu alan kontrolleri ve sayı format denetimleri.
- **Kullanıcı Girişi & Oturum Yönetimi**: Kişisel verilerin güvenliği için kullanıcı hesabı sistemi.

---

## 🛠️ Kullanılan Teknolojiler

- **Backend**: ASP.NET Core MVC (C#)
- **Frontend**: HTML5, CSS3, JavaScript (Custom, Bootstrap kullanılanarak)
- **Veritabanı**: Entity Framework Core (Code First)
- **Grafikler**: Chart.js
- **Oturum Yönetimi**: ASP.NET Core Session

---

## 📂 Proje Yapısı

Gelir_Gider_Takibi/
│
├── Controllers/ # MVC Controller dosyaları
├── Models/ # Veri modelleri (Entity Framework)
├── Views/ # Razor View sayfaları
├── wwwroot/ # Statik dosyalar (CSS, JS, img)
├── Migrations/ # EF Core migration dosyaları
└── Program.cs # Uygulama başlangıç noktası

---

## 🧰 Veritabanı Yapısı

- **ThismonThsalary → Aylık maaş kayıtları
- **ThismonThsalaryspending → Harcamalar (kategori ve tutar bilgisiyle)
- **Categories → Harcama kategorileri
- **Users → Kullanıcı hesapları
- **Admin → Yönetici bilgileri
