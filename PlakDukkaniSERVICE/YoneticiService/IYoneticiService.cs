using PlakDukkaniDATA.Entities;
using System.Linq.Expressions;

namespace PlakDukkaniSERVICE.YoneticiService
{
    public interface IYoneticiService
    {
        void Ekle(Yonetici yonetici);
        void Guncelle(Yonetici yonetici);
        void Sil(Yonetici yonetici);
        Yonetici IdyeGoreGetir(int id);
        List<Yonetici> TumunuGetir();
        List<Yonetici> KosulaGoreGetir(Expression<Func<Yonetici, bool>> expression);
        bool AdSifreKontrolu(string ad, string sifre);
        bool AdSifreKontrolu(string ad);
    }
}
