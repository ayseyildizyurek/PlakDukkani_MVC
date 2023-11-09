using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.HataMesajlari
{
    public static class HataveBilgiMesajlari
    {
        public const string BosAlanHatasi = "Boş alan bırakmayınız.";
        public const string KaydedildiBilgisi = "Kayıt Başarılı";
        public const string GuncellendiBilgisi = "Guncelleme Başarılı";
        public const string SilindiBilgisi = "Silme Başarılı";
        public const string CrudHatalari = "Hata oluştu,tekrar deneyiniz";
        public const string SifreEslesmemeHatasi = "Şifreleriniz eşleşmiyor, tekrar deneyiniz.";
        public const string GecersizKullaniciSifreHatasi = "Geçersiz kullanıcı adı veya şifresi girdiniz.";
        public const string GecersizKullaniciAdiHatasi = "Bu kullanıcı ismi ile kayıt mevcut, farklı bir kullanıcı adı ile tekrar deneyiniz.";
        public const string GecersizSifreHatasi = "Şifreniz oluşturulamadı tekrar deneyiniz.\nŞifre kuralları:\r\n• En az 8 karakter uzunluğunda olmalıdır.\r\n• En az 2 büyük harf içermelidir.\r\n• En az 3 küçük harf içermelidir.\r\n•! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir. (Aynı karakterden birden fazla olabilir).";
    }
}
