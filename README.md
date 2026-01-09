# 🏥 SmartClinic – Akıllı Hasta Yönetim Sistemi

Bu proje, modern kliniklerin hasta takip süreçlerini dijitalleştirmek, kritik vaka yönetimini kolaylaştırmak ve anlık istatistik takibi yapmak amacıyla geliştirilmiş **full-stack** bir yönetim panelidir. 

Proje, kurumsal standartlarda **ABP Framework** altyapısı kullanılarak, mikroservis mantığına yakın bir konteyner yapısıyla (Docker) inşa edilmiştir.

---

## 🚀 Öne Çıkan Özellikler

* **📈 Dinamik Dashboard:** Kritik, orta derece ve stabil hasta sayılarını anlık olarak gösteren istatistik paneli.
* **👥 Hasta Yönetimi:** Hasta kayıt, takip ve taburcu işlemlerinin yönetildiği kapsamlı modül.
* **🔐 Kimlik ve Yetkilendirme:** ABP Identity ve IdentityServer entegrasyonu ile güvenli giriş ve rol yönetimi.
* **🛡️ Sağlık İzleme:** API ve veritabanı durumunu takip eden entegre Health Check sistemi.
* **⚡ Performans:** Veri önbellekleme (Caching) için Redis entegrasyonu.

---

## 🛠️ Kullanılan Teknolojiler

### Backend
* **.NET 8 (C#)** – Güçlü ve modern API altyapısı.
* **ABP Framework** – Modüler mimari ve Domain Driven Design (DDD) standartları.
* **PostgreSQL** – İlişkisel veritabanı yönetimi.
* **Entity Framework Core** – Veritabanı yönetim katmanı (ORM).

### Frontend
* **Angular** – Dinamik ve hızlı kullanıcı arayüzü.
* **Bootstrap** – Modern ve responsive (mobil uyumlu) tasarım.

### Altyapı
* **Docker & Docker Compose** – Konteyner tabanlı dağıtım ve ortam bağımsız çalışma.
* **Redis** – Hızlı erişim için yüksek performanslı önbellek sistemi.

---

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları takip edin:

### 1. Projeyi Klonlayın
```powershell
git clone [https://github.com/berkayyurttas/SmartClinic.git](https://github.com/berkayyurttas/SmartClinic.git)
cd SmartClinic
