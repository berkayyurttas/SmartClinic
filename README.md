# 🏥 SmartClinic - Akıllı Hasta Takip & Triyaj Sistemi

SmartClinic, modern sağlık kuruluşları için geliştirilmiş, hasta kayıt ve triyaj (önceliklendirme) süreçlerini dijitalleştiren web tabanlı bir yönetim sistemidir. 

## 🚀 Proje Amacı
Bu proje; acil servis ve kliniklerdeki hasta yoğunluğunu yönetmek, hastaların aciliyet durumlarını (Kırmızı, Sarı, Yeşil) görselleştirerek sağlık personelinin iş yükünü optimize etmek amacıyla geliştirilmiştir.

## 🛠️ Teknik Altyapı
Proje, kurumsal standartlarda modern bir teknoloji yığını (stack) ile inşa edilmiştir:

* **Backend:** .NET 10 & ABP Framework (Domain Driven Design - DDD)
* **Frontend:** Angular (Modern UI/UX Components)
* **Veritabanı:** PostgreSQL
* **Cache:** Redis
* **Konteynerleştirme:** Docker & Docker-Compose
* **CI/CD:** GitHub Actions (Otomatik Build ve İmaj Dağıtımı)

## 📦 Kurulum ve Çalıştırma

Sistemi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

### 1. Gereksinimler
* Docker Desktop
* .NET 10 SDK
* Node.js & NPM

### 2. Docker ile Hızlı Başlat
Proje dizininde terminali açın ve tüm konteynerleri ayağa kaldırın:
```powershell
docker-compose up -d --build
