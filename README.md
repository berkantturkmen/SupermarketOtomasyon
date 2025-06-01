# 🛒 Süpermarket Otomasyon Sistemi – C# Windows Forms + MySQL

Bu proje, bir süpermarket işletmesinin tüm temel operasyonlarını yönetecek şekilde geliştirilen **C# Windows Forms** ve **MySQL** tabanlı profesyonel bir masaüstü otomasyon sistemidir.  
Yönetici ve personel yetkilendirme sistemiyle birlikte ürün yönetimi, satış işlemleri, stok kontrolü, alt limit uyarıları, PDF raporlama ve fiş yazdırma gibi tüm özellikleri kapsamaktadır.

---

## 🚀 Özellikler

### 👤 Giriş ve Kayıt
- Kullanıcılar kayıt olabilir ve giriş yapabilir.
- Roller: **Yönetici** ve **Personel**
- Rol tabanlı yetkilendirme sistemi

### 🛍️ Ürün Yönetimi (Yönetici)
- Barkod numarasıyla ürün tanımlama
- Ürün ekleme, güncelleme ve silme
- Alt limit belirleyip stok kritik eşiği uyarıları
- Yazıcıya ürün listesi çıktısı (fiş yazdırma desteği)

### 📂 Kategori Yönetimi (Yönetici)
- Yeni kategori ekleme ve silme
- Ürünleri kategori bazlı gruplama

### 💸 Satış Sistemi (Personel ve Yönetici)
- Barkod ile ürün arama
- Miktar seçme ve satış yapma
- **Stoktan düşme**, **veritabanına kayıt**
- Yazıcıdan satış fişi çıktısı alma

### 📦 Stok Görüntüleme (Personel)
- Tüm ürünleri listeleme
- Alt limit altındaki ürünleri görüntüleme

### 📊 Satış Raporları (Yönetici)
- Tarih aralığı seçerek satış dökümü
- Toplam tutar hesaplama
- PDF olarak satış listesini dışa aktarma (`iTextSharp` ile)

### 📝 Sistem Logları (Yönetici)
- Kullanıcı bazlı işlem kayıtları
- Giriş, satış, ürün işlemleri loglanır
- Tarih sırasına göre görüntülenebilir

---

## 🧱 Kullanılan Teknolojiler

| Katman         | Teknoloji                 |
|----------------|---------------------------|
| Programlama    | C# (.NET Framework 4.8)    |
| Veritabanı     | MySQL 8.x                 |
| Arayüz         | Windows Forms             |
| Yazıcı & PDF   | System.Drawing.Printing, iTextSharp |
| Bağlantı       | MySql.Data (NuGet paketi) |

---

## 🗄️ Veritabanı Yapısı

**Veritabanı Adı:** `supermarket_otomasyonu`

### Tablolar:
- `kullanicilar (id, ad, soyad, kullanici_adi, sifre, rol)`
- `urunler (id, barkod_no, urun_adi, kategori, fiyat, stok, alt_limit)`
- `kategori (id, kategori_adi)`
- `satislar (id, urun_id, miktar, toplam_fiyat, tarih, satis_yapan)`
- `loglar (id, kullanici_adi, islem_aciklamasi, tarih)`

⚠️ Tüm yabancı anahtarlar referanslıdır. SQL script dosyası proje içinde yer alır.


