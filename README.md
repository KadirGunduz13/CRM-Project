# CRM Optimization System

## 📌 Proje Açıklaması
Bu proje, müşteri destek temsilcisi yönlendirme ve pazarlama kampanyası seçimi için optimize edilmiş algoritmalar içeren bir **CRM (Customer Relationship Management) sistemi** geliştirmektedir.

## 🚀 Kullanılan Teknolojiler
- **C#** (Ana programlama dili)
- **.NET Core**
- **Dinamik Programlama** (Knapsack Problemi)
- **Veri Yapıları & Algoritmalar**

---

## 📍 Özellikler
### 1️⃣ **Müşteri Destek Temsilcisi Yönlendirme**
- 📌 **Amaç:** Müşteriye en yakın ve uygun destek temsilcisini bulmak.
- 📌 **Algoritma:**
  - Tüm temsilcilerle mesafeler hesaplanır.
  - En kısa mesafeye sahip temsilci atanır.
- 📌 **Zaman Kompleksitesi:** **O(M × A)** (Müşteri × Temsilci)

### 2️⃣ **Pazarlama Kampanyası Seçimi**
- 📌 **Amaç:** Bütçeyi aşmadan en yüksek ROI (Yatırım Getirisi) sağlayan kampanyaları seçmek.
- 📌 **Algoritma:**
  - **Dinamik Programlama** ile **Knapsack (Sırt Çantası) Problemi** çözümü uygulanır.
  - En uygun kampanyalar seçilir.
- 📌 **Zaman Kompleksitesi:** **O(N × B)** (Kampanya × Bütçe)

---

## 🛠 Kullanım

### 📥 **Projeyi Çalıştırma**
1. **Projeyi Kendi Bilgisayarınıza Klonlayın:**
   ```sh
   git clone https://github.com/kadirgunduz/crm-optimization.git
   cd crm-optimization
   ```
2. **Visual Studio veya .NET CLI ile Çalıştırın:**
   ```sh
   dotnet run
   ```

---

## 📊 Örnek Çıktı
```plaintext
En iyi temsilci: Ahmet (Uzaklık: 3.5 km)
En yüksek ROI: 330
Seçilen Kampanyalar:
- Instagram Reklamı
- YouTube Sponsorluğu
```

---

## 📌 İletişim
Bu proje hakkında herhangi bir sorunuz varsa benimle iletişime geçebilirsiniz:
📧 **E-posta:** kadir.gunduz@example.com

👨‍💻 **Geliştirici:** **Kadir Gündüz**
