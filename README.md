# Telefon Rehberi Web Servisi (.NET Core + Firebird)

Bu proje, web ve mobil uygulamalar tarafından kullanılmak üzere geliştirilmiş bir RESTful telefon rehberi servisidir. Kullanıcılar kişi ekleyebilir, silebilir, güncelleyebilir ve konum bazlı istatistikleri sorgulayabilir. Veritabanı olarak **Firebird** tercih edilmiştir.

## 🎯 Özellikler

- Rehbere kişi ekleme, silme ve güncelleme
- Rehberdeki kişilerin listelenmesi
- Kişiye ait iletişim bilgilerinin yönetimi
- Konuma göre kişi sayısı ve numara istatistikleri
- En çok/en az konumlara göre sıralama
- UUID ile kayıt takibi

## 🧱 Kullanılan Teknolojiler

- .NET Core 6+
- Firebird SQL (veritabanı)
- Entity Framework Core (code-first + migration)
- Git
- xUnit ile Unit Testing
- Swagger (API dokümantasyonu)

## ❌ Kullanılmayan Teknolojiler

- Redis
- PostgreSQL / MSSQL / MongoDB

## 🔧 Kurulum ve Çalıştırma

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/kullanici-adi/telefon-rehberi-api.git
   cd telefon-rehberi-api
