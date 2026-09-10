# Dormitory E-Commerce Platform

![C#](https://img.shields.io/badge/C%23-ASP.NET%20MVC-512BD4?logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=.net&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-6.4.4-68217A)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Docker-CC2927?logo=microsoftsqlserver&logoColor=white)

Yurt ortamında öğrencilerin ürünleri inceleyebildiği, sepete ekleyebildiği ve kullanıcı hesabı oluşturabildiği mini bir e-ticaret platformu.

Proje, öğrencilerin yurtlarda asansörlere astığı ilanlardan ilham alınarak geliştirilmiştir. Uygulamanın arayüzünde **Asansör Butik** adı kullanılır.

## Proje hakkında

Bu proje, 2024 yılında üniversitede 2. sınıfta verilen ASP.NET web programlama ödevi kapsamında geliştirilmiş bir mini e-ticaret uygulamasıdır. Öğrencilerin yurt ortamında birbirlerine ürün ilanı verebilmesi fikrinden yola çıkılarak **Asansör Butik** adıyla hazırlanmıştır.

Uygulamada ürün ve kategori listeleme, ürün detayları, kullanıcı kaydı ve girişi, sepet işlemleri ile yönetici tarafında ürün ve kategori yönetimi bulunur. Proje ASP.NET MVC 5, Entity Framework, ASP.NET Identity ve SQL Server kullanılarak geliştirilmiştir.

## Özellikler

- Ürünleri ana sayfada ve kategorilere göre listeleme
- Ürün detaylarını görüntüleme
- Kullanıcı kaydı ve girişi
- Alışveriş sepetine ürün ekleme ve sepetten çıkarma
- Yönetici rolüyle ürün ve kategori yönetimi
- Entity Framework Code First ile veritabanı oluşturma
- İlk çalıştırmada örnek kategori, ürün, kullanıcı ve rol verilerini oluşturma

## Ekran görüntüleri

### Kullanıcı tarafı

<table>
  <tr>
    <td align="center" width="50%"><img src="docs/screenshots/live/home.png" alt="Asansör Butik ana sayfası" width="480"><br><strong>Ana sayfa</strong><br>Marka tanıtımı ve kategoriler.</td>
    <td align="center" width="50%"><img src="docs/screenshots/live/product-list.png" alt="Ürün listesi" width="480"><br><strong>Ürün listesi</strong><br>Kategorilere göre ürünleri inceleme.</td>
  </tr>
  <tr>
    <td align="center"><img src="docs/screenshots/live/category-camera.png" alt="Kamera kategorisi" width="480"><br><strong>Kategori filtresi</strong><br>Seçilen kategoriye ait ürünleri listeleme.</td>
    <td align="center"><img src="docs/screenshots/live/product-details.png" alt="Ürün detayları" width="480"><br><strong>Ürün detayları</strong><br>Ürün görseli, fiyatı, stok bilgisi ve sepete ekleme.</td>
  </tr>
  <tr>
    <td align="center"><img src="docs/screenshots/live/login.png" alt="Kullanıcı giriş ekranı" width="480"><br><strong>Giriş</strong><br>Kullanıcı hesabıyla oturum açma.</td>
    <td align="center"><img src="docs/screenshots/live/register.png" alt="Kullanıcı kayıt ekranı" width="480"><br><strong>Kayıt</strong><br>Yeni kullanıcı hesabı oluşturma.</td>
  </tr>
  <tr>
    <td align="center"><img src="docs/screenshots/live/cart-filled.png" alt="Dolu alışveriş sepeti" width="480"><br><strong>Dolu sepet</strong><br>Ürün görseli, adet, fiyat ve toplam tutar.</td>
    <td align="center"><img src="docs/screenshots/live/cart.png" alt="Boş alışveriş sepeti" width="480"><br><strong>Boş sepet</strong><br>Sepette ürün olmadığında gösterilen durum.</td>
  </tr>
</table>

### Yönetim paneli

<table>
  <tr>
    <td align="center" width="50%"><img src="docs/screenshots/live/admin-products.png" alt="Yönetici ürün listesi" width="480"><br><strong>Ürün yönetimi</strong><br>Ürünleri listeleme, güncelleme ve silme.</td>
    <td align="center" width="50%"><img src="docs/screenshots/live/admin-product-details.png" alt="Yönetici ürün detayları" width="480"><br><strong>Ürün detayları</strong><br>Yönetici görünümünde ürün bilgileri.</td>
  </tr>
  <tr>
    <td align="center"><img src="docs/screenshots/live/admin-product-create.png" alt="Yeni ürün ekleme" width="480"><br><strong>Ürün ekleme</strong><br>Yeni ürün bilgilerini ve görselini tanımlama.</td>
    <td align="center"><img src="docs/screenshots/live/admin-product-edit.png" alt="Ürün düzenleme" width="480"><br><strong>Ürün düzenleme</strong><br>Ürün bilgilerini güncelleme.</td>
  </tr>
  <tr>
    <td align="center"><img src="docs/screenshots/live/admin-product-delete.png" alt="Ürün silme onayı" width="480"><br><strong>Ürün silme</strong><br>Silme işlemi öncesi onay ekranı.</td>
    <td align="center"><img src="docs/screenshots/live/admin-categories.png" alt="Kategori yönetimi" width="480"><br><strong>Kategori yönetimi</strong><br>Kategorileri listeleme, güncelleme ve silme.</td>
  </tr>
  <tr>
    <td align="center" colspan="2"><img src="docs/screenshots/live/admin-category-create.png" alt="Yeni kategori ekleme" width="480"><br><strong>Kategori ekleme</strong><br>Yeni kategori adı ve açıklaması oluşturma.</td>
  </tr>
</table>

## Kullanılan teknolojiler

- C#
- ASP.NET MVC 5
- .NET Framework 4.7.2
- Entity Framework 6.4.4
- ASP.NET Identity ve OWIN
- SQL Server 2022 Express (Docker)
- IIS Express
- Bootstrap 4
- HTML ve CSS

## Gereksinimler

- Windows
- Visual Studio 2022 Community
- Visual Studio Installer içinden **ASP.NET and web development** workload'u
- .NET Framework 4.7.2 Developer/Targeting Pack
- Docker Desktop

Node.js, Python, Java veya tam SQL Server kurulumu gerekli değildir.

## Kurulum ve çalıştırma

1. Repoyu klonlayın:

   ```powershell
   git clone https://github.com/emirkvrak/Dormitory-ECommerce-Platform.git
   cd Dormitory-ECommerce-Platform
   ```

2. Yerel Docker ayar dosyasını oluşturun:

   ```powershell
   Copy-Item .env.example .env
   ```

   `.env` dosyası Git'e gönderilmez.

3. SQL Server konteynerini başlatın ve veritabanını oluşturun:

   ```powershell
   docker compose up -d
   docker exec dormitory-ecommerce-db /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "DormitoryDev_2026!Safe" -C -Q "IF DB_ID(N'ETicaretDb') IS NULL CREATE DATABASE [ETicaretDb];"
   ```

4. `ETicaret.sln` dosyasını Visual Studio ile açın. Gerekirse NuGet paketlerini restore edin.

5. `ETicaret.MvcWebUI` projesini başlangıç projesi yapıp IIS Express ile çalıştırın.

Uygulama Visual Studio'nun gösterdiği yerel adreste açılır. IIS Express ile elle çalıştırmak için örnek:

```powershell
& "C:\Program Files\IIS Express\iisexpress.exe" /path:"$PWD\ETicaret.MvcWebUI" /port:50580
```

Ardından `http://localhost:50580/` adresini açın.

## Uygulama akışı

```mermaid
flowchart LR
    A[Ziyaretçi] --> B[Ana sayfa]
    B --> C[Kategori ve ürün listesi]
    C --> D[Ürün detayları]
    D --> E[Alışveriş sepeti]
    A --> F[Giriş / Kayıt]
    F --> E
    G[Admin kullanıcı] --> H[Yönetim paneli]
    H --> I[Ürün yönetimi]
    H --> J[Kategori yönetimi]
    I --> K[(SQL Server)]
    J --> K
    E --> K
```

## Durdurma ve temizleme

Konteyneri durdurmak için:

```powershell
docker compose down
```

Konteynerle birlikte yerel veritabanı volume'unu da silmek için:

```powershell
docker compose down -v
```

## Veritabanı ve demo hesapları

Uygulama Docker üzerindeki `localhost,14333` SQL Server bağlantısını kullanır. `ETicaretDb` veritabanı yukarıdaki Docker komutuyla oluşturulur; tablolar ve örnek veriler Entity Framework initializer sınıfları tarafından ilk uygulama açılışında eklenir.

| Kullanıcı adı | Rol | Parola |
|---|---|---|
| `demo.admin` | Admin, User | `1234567` |
| `demo.user` | User | `1234567` |

Bu hesaplar yalnızca yerel geliştirme ve gösterim içindir.

## Proje yapısı

```text
ETicaret.sln
├── ETicaret.MvcWebUI
│   ├── Controllers
│   ├── Entity
│   ├── Identity
│   ├── Models
│   ├── Views
│   ├── Scripts
│   ├── theme
│   ├── Upload
│   ├── Web.config
│   └── packages.config
├── docs
│   └── screenshots/live
├── docker-compose.yml
└── .env.example
```

`Controllers` istekleri ve kullanıcı akışlarını, `Entity` veritabanı modelleri ile Entity Framework yapılandırmasını, `Identity` kullanıcı ve rol yönetimini, `Views` arayüz ekranlarını, `Upload` ise ürün ve kategori görsellerini içerir.
