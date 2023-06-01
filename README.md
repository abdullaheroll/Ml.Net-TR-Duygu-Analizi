# Ml.Net TR Duygu Analizi

-------------------------

Özellikle e-ticaret sitelerinde müşterilerin ürün yorumlarını analiz etmek, işletmelerin müşteri memnuniyetini artırmak, ürün kalitesini iyileştirmek ve pazarlama stratejilerini optimize etmek için önemli bir fırsattır. Ancak, yorumların büyük miktarda ve çeşitli dillerde olması, bu analizi zorlaştırmaktadır. Bu nedenle, duygu analizi gibi makine öğrenimi tekniklerinin kullanılması gerekmektedir.

Duygu analizi, metin verilerindeki duyguları veya tutumları otomatik olarak tanımlamak ve sınıflandırmak için kullanılan bir doğal dil işleme yöntemidir. Duygu analizi, metin verilerini pozitif, negatif veya nötr gibi önceden tanımlanmış kategorilere göre etiketleyebilir.

Bu projede, ML.NET ile e-ticaret sitelerinde veya herhangi bir yerde kullanılabilecek bir duygu analizi programı geliştirdim. ML.NET, .NET platformunda makine öğrenimi uygulamaları geliştirmek için Microsoft tarafından sağlanan açık kaynaklı bir çerçevedir. ML.NET, veri yükleme, veri hazırlama, model oluşturma, model eğitme ve model değerlendirme gibi makine öğrenimi iş akışlarını kolaylaştıran araçlar ve API'ler sunmaktadır.

Projemde kullandığım veri kümesi, https://www.kaggle.com/datasets/burhanbilenn/turkish-customer-reviews-for-binary-classification adresinden indirdiğim Türkçe ürün yorumları içeren bir veri kümesidir. Veri kümesinde 8485 adet yorum ve bunların duygu etiketleri bulunmaktadır.

ML.NET yapısını kullanarak, veri kümesini yükledim ve verileri modelime uygun hale getirmek için bazı dönüşümler uyguladım. Daha sonra, ML.NET'in sunduğu hazır algoritmalardan biri olan SdcaLogisticRegression'u kullanarak bir sınıflandırma modeli oluşturdum. Modelimi eğitmek için veri kümesinin %80'ini eğitim verisi olarak kullandım ve kalan %20'sini test verisi olarak ayırdım. Modelimi 1 saat süreyle eğittim ve sonrasında test verisi üzerinde değerlendirdim.

Modelimin performansını ölçmek için doğruluk (accuracy) skoru gibi metrikler kullandım. Modelimin doğruluk payı neredeyse %90 olarak çıktı. Bu da modelimin ürün yorumlarının duygularını oldukça iyi tahmin edebildiğini gösteriyor.

Projemin sonucunda, ML.NET ile e-ticaret sitelerinde veye herhangi bir projede kullanılabilecek bir duygu analizi programı geliştirmiş oldum. Bu program sayesinde, işletmeler müşterilerin ürünler hakkındaki görüşlerini daha kolay anlayabilir ve buna göre hareket edebilirler. Projemin avantajları arasında ML.NET'in kolay kullanımı, performansı ve .NET platformu ile uyumluluğu sayılabilir. Projemin sınırlamaları arasında ise veri kümesinin küçük boyutu, Türkçe dilinin zorluğu ve duygu analizinin karmaşıklığı sayılabilir.

Projemi geliştirmek için gelecekte yapmayı planladığım çalışmalar arasında şunlar var:

- Daha büyük ve çeşitli bir veri kümesi kullanmak
- Farklı dillerde duygu analizi yapmak
- Farklı makine öğrenimi algoritmalarını denemek
- Duygu etiketlerini daha detaylı hale getirmek (örneğin çok pozitif, pozitif, nötr, negatif, çok negatif)

---
