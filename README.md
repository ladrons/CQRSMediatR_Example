# CQRS: Komut ve Sorgu Sorumluluk Ayrımı 🚀

**CQRS** *(Command Query Responsibility Segregation)*, yazılım dünyasında veri işlemlerini daha verimli ve ölçeklenebilir bir şekilde yönetmek için kullanılan bir tasarım desenidir. Bu yaklaşımı uygulamanızda kullanarak veri yönetimini iki ana bölüme ayırabilir ve böylece performansı artırıp bakımını daha kolay hale getirebilirsiniz. 📈

Bu API uygulamasında, 'Product' modeli üzerinden sahte bir veritabanı kullanarak CQRS işlemlerini gerçekleştirdim. Ayrıca, süreci daha da basitleştirmek için 'MediatR' kütüphanesinden yararlandım.

CQRS hakkında daha fazla bilgi ve detayları alt kısımda bulabilirsiniz.

## CQRS Nedir? 🤔

CQRS, **"Command"** *(Komut)* ve **"Query"** *(Sorgu)* işlemlerini ayıran bir yaklaşımdır. Komutlar sistemdeki durumu değiştirirken, sorgular sadece veriyi okur ve durumu değiştirmez. Bu ayrım performansı artırır ve bakımı basitleştirir.

### Komutlar (Commands) 📝

Komutlar, sistemin durumunu değiştiren işlemlerdir. Örneğin, kullanıcı kaydı oluşturmak veya ürün eklemek gibi işlemler. Genellikle iş mantığı içerir ve "Write Model" ile çalışır.

### Sorgular (Queries) 🔍

Sorgular, veri okuma işlemleridir ve sistemi değiştirmez. Performansı artırmak için genellikle "Read Model" ile çalışır ve daha hızlı olabilir.

#### CQRS’in Avantajları 🌟

- **Performans İyileştirmeleri:** Komutlar ve sorgular için ayrı veri yapıları kullanmak, genel performansı artırır. 🚀

- **Ölçeklenebilirlik:** Komut ve sorgu işlemlerini ayrı ayrı ölçeklendirebilirsiniz. 📊

- **Basitleştirilmiş Bakım:** Ayrı iş mantığı ve veri modelleri, kodun anlaşılmasını ve bakımını kolaylaştırır. 🧩

- **Gelişmiş Güvenlik:** Komut ve sorguların ayrılması, daha detaylı ve güvenli erişim kontrolü sağlar. 🔒
