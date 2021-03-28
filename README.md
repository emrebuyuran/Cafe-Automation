# Cafe-Automation
Object oriented programming project with Windows Forms

Kullanıcı ve Müşteri Tanımları : Program kimlere hitap ediyor => İşletme sahibi yani restoran tarzı gıda ve dinlenme hizmeti veren işletmelerinin işletmecilerine.

Kullanıcı ve Müşteri Tanımları : Kullanıcılar ise => işletme sahibi admin 
işletme sahibinin yetkilendirdiği -> administration yetkileri (çalışanlar)
Müşteriler=> Restoran, kafe vb. gıda ve dinlenme hizmeti veren işletmelerden faydalanan insanlar.

Proje Hakkında: Proje restoran, kafe vb. gıda ve dinlenme hizmeti veren işletmelerin ihtiyaçlarına uygun olacak şekilde tasarlanmıştır. Bu işletmelere ait ihtiyaçları karşılayabilecek düzeydedir. Yazılan kodların tamamının İngilizce olmasına özen gösterilmiştir.

Özellikler: Giriş Paneli, Menü paneli, Masa ekleme-çıkarma(15 Masaya kadar*), Masa durumunu gösterme(dolu-boş-rezerve-açık rezerve), Masaya sipariş ekleme/değiştirme, 
Masa formunda ürün arama, Ödeme alma, Adisyon çıktısı alma, Müşteri ekleme-güncelleme-arama, 
Mutfak formu(kategori/ürün ekleme*, çıkarma, güncelleme), Kasa işlemleri formu (geçmişe dönük rapor, satış raporları istatistikleri vs.), 
Rezervasyon formu, Paket Sipariş formu(Paket sipariş açma/kapama, paket sipariş durumu), Raporlar, Ayarlar(Personel yetkilendirme-ekleme çıkarma), Uygulamayı Kilitle, Çıkış.

*15 masa olmasının sebebi, form boyutu ve butonların büyüklüğüne göre maksimum kapasite olmasından dolayıdır. Boyutlar güncellenirse sınırsız ekleme/çıkarma yapılabilir.
*Kategori ekleme form boyutundan dolayı 10 kategori ile sınırlandırılmıştır. Boyutlar güncellenirse sınırsız ekleme/çıkarma yapılabilir.

Proje Planlaması : Kafe kontrol uygulamam için gerekli sınıfları oluşturdum, gerekli formları oluşturdum ve tasarladım, gerekli veritabanını yazdım ve bağlantılarını yaptım.

Veritabanı : Veritabanı 14 tablodan oluşmakta;
billPayments -> Tamamlanmış ödemeleri tutar.
bills-> Adisyon bilgilerini tutar.
categories -> Kategori bilgilerini tutar.
Customers -> Müşteri bilgilerini tutar.
packOrders -> Paket siparişleri tutar.
paymentTypes->Ödeme türlerini tutar(Nakit-Kredi Kartı-Ticket)
personnelActions->Personel girişlerini kaydeder.
personnels-> Personel bilgilerini tutar.
personnelTasks->Personel görevlerini tutar.(çalıştığı pozisyon)
products->Ürün bilgilerini tutar.
reservations->Rezervasyon bilgilerini tutar.
sales->Ürün satışlarını listeler.
serviceTypes->Servis türlerini listeler(Masaya veya paket servis)
tables->Masaların bilgisini tutar.
