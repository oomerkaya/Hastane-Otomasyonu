# Hastane Otomasyonu

C# ve Windows Forms ile hazırlanmış masaüstü hastane otomasyonu örneği. Hasta kayıt ve randevu akışını, doktor ve sekreter ekranlarını, ayrıca hastane hakkında bilgilendirme sayfalarını bir araya getirir.

## Uygulama akışı

1. Ana ekrandan hasta randevu girişine veya yetkili girişine geçilir.
2. Yeni hasta; ad, soyad, T.C. kimlik numarası, cinsiyet ve doğum yılı bilgileriyle kaydedilir.
3. Kayıtlı hasta T.C. kimlik numarası ve uygulamanın ürettiği şifreyle giriş yapar.
4. Randevu ekranında bölüm, o bölüme bağlı doktor, tarih ve saat seçilir.
5. Yetkili ekranlarında rol bazlı listeler ve randevu özetleri görüntülenir.

## Özellikler

- Hasta kaydı ve hasta girişi
- Branş/doktor seçimi ile tarih ve saat belirleyerek randevu oluşturma
- Aktif ve geçmiş randevuları görüntüleme ve randevu kaydını silme
- Doktor görünümünde kayıtlı hasta/randevu listeleri ile branşa ve doktora göre randevu sayıları
- Sekreter görünümünde hasta/randevu kayıtları, doktor listesi ve grafik ekranı
- Hastane ana sayfası, bölümler, tarihçe, misyon ve vizyon, iletişim ve görüş/şikâyet ekranları

## Teknolojiler

- C# / Windows Forms
- .NET Framework 4.7.2
- Microsoft SQL Server ve ADO.NET (`System.Data.SqlClient`)
- MaterialSkin 0.2.1 ve ModernUI (MetroFramework)

## Kurulum ve çalıştırma

1. Windows'ta Visual Studio ile `Hastane Otosmasyonu for git/Hastane Otomasyonu.sln` dosyasını açın.
2. NuGet paketlerini geri yükleyin ve projeyi derleyin.
3. SQL Server'da uygulamanın beklediği `Hastane_Otomasyonu` veritabanını ve tablolarını hazırlayın. Depoda veritabanı oluşturma betiği bulunmuyor.
4. `Veritabani.cs` içindeki bağlantı dizesini kendi SQL Server sunucunuza göre düzenleyin.
5. Başlangıç projesini çalıştırın.

## Yapılandırma notları

Bağlantı dizesi şu anda yerel bir sunucu adını ve Windows kimlik doğrulamasını kullanıyor. Uygulamayı farklı bir bilgisayara taşırken sunucu adı, kimlik doğrulama yöntemi ve veritabanı adını kontrol edin. Kod hasta ve randevu bilgilerini SQL Server'daki `Table_HastaBilgi` ve `Table_RandevuBilgi` tablolarında arar/kaydeder.

> Bu depo eğitim amaçlı bir örnektir. Kimlik doğrulama ve veri yönetimini gerçek hasta bilgileriyle kullanım için uygun varsaymayın.