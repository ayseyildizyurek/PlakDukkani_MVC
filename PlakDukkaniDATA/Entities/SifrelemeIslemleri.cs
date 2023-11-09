using System.Security.Cryptography;
using System.Text;

namespace PlakDukkaniDATA.Entities
{
    public static class SifrelemeIslemleri
    {
        /// <summary>
        /// Kullanici sifrelerini veritabanına guvenli halde saklar
        /// </summary>
        /// <param name="sifre"></param>
        /// <param name="tuz"></param>
        /// <returns></returns>
        public static string Sifrele(string sifre, string tuz)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] tuzBytes = Encoding.UTF8.GetBytes(tuz);
                byte[] sifreBytes = Encoding.UTF8.GetBytes(sifre);

                byte[] toBeHashed = new byte[sifreBytes.Length + tuzBytes.Length];
                Buffer.BlockCopy(sifreBytes, 0, toBeHashed, 0, sifreBytes.Length);
                Buffer.BlockCopy(tuzBytes, 0, toBeHashed, sifreBytes.Length, tuzBytes.Length);

                return string.Concat(hash.ComputeHash(toBeHashed).Select(b => b.ToString("X2")));
            }
        }
    }
}
