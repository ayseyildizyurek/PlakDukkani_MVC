using PlakDukkaniDAL.Context;
using PlakDukkaniDAL.Interfaces;
using PlakDukkaniDATA.Entities;

namespace PlakDukkaniDAL.Concretes
{
    public class YoneticiDAL : BaseDal<Yonetici>, IYoneticiDAL
    {
        PlakDukkaniDbContext db;
        public bool AdSifreKontrolu(string ad, string sifre)
        {
            using (db = new PlakDukkaniDbContext())
            {
                return db.Set<Yonetici>().Where(x => x.Ad == ad && x.Sifre == SifrelemeIslemleri.Sifrele(sifre, ad)).Any();
            }
        }

        public bool AdSifreKontrolu(string ad)
        {
            using (db = new PlakDukkaniDbContext())
            {
                return db.Set<Yonetici>().Where(x => x.Ad == ad).Any();
            }
        }
    }
}
