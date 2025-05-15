# RestaruntApp

## Proje Hakkında

**RestaruntApp**, restaurant ve cafe yönetimini kolaylaştırmak için geliştirilen bir uygulamadır. Bu proje, restaurantlarda kullanılabilecek yönetimsel bir çözüm sunmayı hedeflemektedir. Şu anda proje geliştirme aşamasında olup, temel yapılar ve katmanlar oluşturulmaktadır. Aynı zamanda bu proje, GitHub profilimde benim teknik seviyemi göstermek için tasarlanmıştır.

## Katmanlar

Proje, toplamda 6 farklı katmandan oluşmaktadır:

1. **DAL (Data Access Layer)**:
   - `RestaurantContext` sınıfı oluşturuldu ve `DbContext`'ten miras alındı.
   - Migrations işlemleri yapılarak veritabanı ve tablolar SQL'e yansıtıldı.

2. **BLL (Business Logic Layer)**:
   - İş mantığı ile ilgili işlemler bu katmanda geliştirilecektir.

3. **ENTITIES**:
   - Aşağıdaki sınıflar oluşturuldu:
     - `Category`
     - `Permission`
     - `Product`
     - `Role`
     - `Staff`

4. **TESTS**:
   - Projede kullanılan fonksiyonların ve mantıkların test edilmesi için bu katman kullanılacaktır.

5. **UI (User Interface)**:
   - Kullanıcı arayüzü bu katmanda geliştirilecektir.

6. **UTILITIES**:
   - Yardımcı araçlar ve fonksiyonlar bu katmanda yer alacak.

## Kullanım

Proje şu anda geliştirme aşamasında olduğu için direkt kullanılabilir durumda değildir. Ancak, ileride proje tamamlandığında:

1. **Kurulum Talimatları**:
   - `.sln` dosyasını indirerek projeyi çalıştırabilirsiniz.
   - Gerekli bağımlılıkları yüklemeyi unutmayın.

2. **Çalıştırma**:
   - Visual Studio gibi bir IDE kullanarak projeyi açın ve çalıştırın.

## Lisans

Bu proje şu anda herhangi bir lisansa sahip değildir.

## Geliştirme Durumu

Projenin aktif olarak geliştirilmesi devam etmektedir. Katkıda bulunmak veya önerilerde bulunmak isterseniz, benimle iletişime geçebilirsiniz.
