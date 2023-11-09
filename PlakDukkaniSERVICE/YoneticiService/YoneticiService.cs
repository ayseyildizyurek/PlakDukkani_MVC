using PlakDukkaniDAL.Concretes;
using PlakDukkaniDATA.Entities;
using System.Linq.Expressions;

namespace PlakDukkaniSERVICE.YoneticiService
{
    public class YoneticiService : IYoneticiService
    {
        YoneticiDAL yoneticiDal = new YoneticiDAL();

        public bool AdSifreKontrolu(string ad, string sifre)
        {
          return yoneticiDal.AdSifreKontrolu(ad, sifre);
        }

        public bool AdSifreKontrolu(string ad)
        {
            return yoneticiDal.AdSifreKontrolu(ad);
        }

        public void Ekle(Yonetici yonetici)
        {
            yoneticiDal.Ekle(yonetici);
        }

        public void Guncelle(Yonetici yonetici)
        {
           yoneticiDal.Guncelle(yonetici);
        }

        public Yonetici IdyeGoreGetir(int id)
        {
            return yoneticiDal.IdyeGoreGetir(id);
        }

        public List<Yonetici> KosulaGoreGetir(Expression<Func<Yonetici, bool>> expression)
        {
            return yoneticiDal.KosulaGoreGetir(expression);
        }

        public void Sil(Yonetici yonetici)
        {
            yoneticiDal.Sil(yonetici);
        }

        public List<Yonetici> TumunuGetir()
        {
           return yoneticiDal.TumunuGetir();
        }
    }
}
