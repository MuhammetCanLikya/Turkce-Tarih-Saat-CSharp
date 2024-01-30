# C# Türkce Tarih Saat Metodu

# Türkçe DateTime TR

Bu küçük C# sınıfı, Türkçe tarih ve saat bilgilerini belirli bir formatta formatlamak için kullanılır. Özellikle Türkçe dilinde tarih ve saat bilgileri ile çalışan uygulamalarda kullanılabilir.

## Nasıl Kullanılır?

Projenize bu sınıfı eklemek için aşağıdaki adımları izleyebilirsiniz:

1. `Tarih.cs` dosyasını projenize ekleyin.
2. Sınıfı kullanmak için aşağıdaki örnek kodu kullanabilirsiniz:

    ```csharp
    using System;

    class Program
    {
        static void Main()
        {
            string tarih =Tarih.Tarih_TR();
            Console.WriteLine(tarih);
        }
    }
    ```
3. Program çıktısı aşağıdaki gibi olacaktır
   ```
   31 Ocak 2024 Çarşamba
   02:16
   ```
## Metodlar

### `Tarih_TR()`

Bu metod, Türkçe tarih ve saat bilgilerini belirli bir formatta formatlar ve bir string olarak döndürür.



# Katkıda Bulunma
## Eğer bu projeye katkıda bulunmak istiyorsanız, lütfen forklayın ve pull request gönderin. Her türlü katkı ve geri bildirimleriniz memnuniyetle karşılanacaktır.
