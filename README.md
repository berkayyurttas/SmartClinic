# 🏥 SmartClinic: Akıllı Hasta Takip & Triyaj Yönetim Sistemi

SmartClinic, sağlık kuruluşlarında hasta kayıt süreçlerini modernize eden ve acil servislerdeki kritik **triyaj (önceliklendirme)** operasyonlarını yöneten kurumsal seviyede bir ekosistemdir.

## 🌟 Proje Vizyonu
Bu sistem, hastaların şikayet ve hayati bulgularına göre otomatik olarak **Kırmızı (Kritik), Sarı (Acil) ve Yeşil (Stabil)** kodlarıyla sınıflandırılmasını sağlar. Amacımız, sağlık personelinin üzerindeki karar yükünü azaltmak ve müdahale sürelerini optimize ederek hayat kurtarmaktır.

---

## 🛠️ Teknik Mimari ve Teknoloji Yığını
Proje, **Domain Driven Design (DDD)** prensipleriyle tasarlanmış olup **ABP Framework** altyapısını kullanmaktadır:

* **Backend:** .NET 10 (C#) & Web API
* **Frontend:** Angular (SPA - Single Page Application)
* **Veritabanı:** PostgreSQL (PostgreSQL 16+)
* **Caching:** Redis (Performans ve oturum yönetimi için)
* **Konteynerleştirme:** Docker & Docker-Compose (Tüm servisler izole edilmiştir)
* **CI/CD:** GitHub Actions (Otomatik Derleme ve Deployment Hattı)

---

## 🚀 Hızlı Kurulum Rehberi (Docker)

Proje, hiçbir kurulum zahmetine girmeden Docker üzerinden çalışacak şekilde optimize edilmiştir:

### 1. Servisleri Başlatma
Terminalde proje ana dizinine gidin ve konteynerleri inşa ederek başlatın:
```powershell
docker-compose up -d --build
