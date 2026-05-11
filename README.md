# HesapMakinesi

Bu repository bir Windows Forms (WinForms) hesap makinesi uygulaması içerir.

- Dil: C# (7.3)
- Hedef: .NET Framework 4.7.2

Açıklama

- Rakam butonları, operatörler (+ - X /), `=` ve `C` (temizle) çalışır.
- Ondalık giriş `.` veya `,` ile yapılır.
- İşlem zinciri desteği vardır (örn. `2 + 3 + 4` otomatik ara hesaplama).

Nasıl çalıştırılır (kaynak koddan)

1. Visual Studio ile aç
   - `HesapMakinesi.sln` ya da `HesapMakinesi` projesini Visual Studio 2022/2026 ile açın.
   - Build Configuration'ı `Release` olarak seçin.
   - `Build -> Rebuild Solution` yapın.
   - `F5` ile çalıştırın veya `bin\Release` içindeki exe dosyasını çalıştırın.

2. (PowerShell) Derleme ve paketleme (kolay yol)
   - Proje dizinine gidin:
     ```powershell
     cd "C:\Users\ACER\OneDrive\Desktop\HesapMakinesi\HesapMakinesi"
     ```
   - Visual Studio'da `Release` derlemesini tamamladıktan sonra `bin\Release` klasörünü ZIP'leyin:
     ```powershell
     Compress-Archive -Path .\bin\Release\* -DestinationPath ..\HesapMakinesi-Release.zip
     ```
   - Oluşan `HesapMakinesi-Release.zip` dosyasını GitHub web arayüzünden repo'nun `Releases` bölümüne veya `Code -> Add file -> Upload files` ile yükleyebilirsiniz.

Nasıl GitHub'a kaynak kodu yollarım (kısaca)

1. GitHub'da boş bir repo oluşturun (örnek: `HesapMakinesi`).
2. Yerelde terminalde proje klasöründeyken:
   ```powershell
   git init
   git add .
   git commit -m "Initial commit: HesapMakinesi"
   git remote add origin https://github.com/<kullaniciadi>/HesapMakinesi.git
   git branch -M main
   git push -u origin main
   ```
3. Kaynak kodu yükledikten sonra `Releases` -> `Draft a new release` ile `HesapMakinesi-Release.zip` dosyasını ekleyip yayınlayabilirsiniz.

Notlar

- ZIP içine `bin\Release` içeriğini koyarsanız, indirenler ZIP'i açıp exe'yi doğrudan çalıştırabilir (çalıştırma için .NET Framework 4.7.2 yüklü olmalıdır).
- Eğer kullanıcıların Visual Studio olmadan çalıştırmasını istiyorsanız `bin\Release` içindeki exe ve bağımlılıkları paylaşın (veya `Publish` ile tek paket oluşturun).

Sorun yaşarsanız bana bildir, adım adım yardımcı olurum.