using PlakDukkaniDAL.Context;
using PlakDukkaniDAL.Interfaces;
using PlakDukkaniDATA.Dtos;
using PlakDukkaniDATA.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace PlakDukkaniDAL.Concretes
{
    public class AlbumDAL : BaseDal<Album>, IAlbumDAL
    {
        PlakDukkaniDbContext db;
        /// <summary>
        /// Veritabanındaki albumleri kayit tarihleri yeniden eskiye gore siralar ve verilen parametredeki adet kadarını listeler. 
        /// </summary>
        /// <param name="adet"></param>
        /// <returns></returns>
        public List<AlbumDto> EnYeniAlbumGetir(int adet)
        {
            using (db = new PlakDukkaniDbContext())
            {
                return db.Set<Album>().OrderByDescending(x => x.KayitTarihi).Take(adet).ToList().Select(x => new AlbumDto
                {
                    Ad = x.Ad,
                    Sanatci = x.Sanatci
                }).ToList();
            }
        }

        public List<AlbumDto> IndirimlileriGetir()
        {
            using (db = new PlakDukkaniDbContext())
            {
                return db.Set<Album>().Where(x => x.IndirimOrani > 0).OrderByDescending(x => x.IndirimOrani).Select(x => new AlbumDto
                {
                    Ad = x.Ad,
                    Sanatci = x.Sanatci
                }).ToList();
            }
        }

        public List<AlbumDto> SatisDevamMiyaGoreGetir(bool satisDevamEdiyorMu)
        {
            using (db = new PlakDukkaniDbContext())
            {
                return db.Set<Album>().Where(x => x.SatisDevamMi == satisDevamEdiyorMu).ToList()
                    .Select(x => new AlbumDto
                    {
                         Ad = x.Ad,
                         Sanatci = x.Sanatci
                     }).ToList();

            }
        }

        public void Sil(Album album)
        {
            using (db = new PlakDukkaniDbContext())
            {
                db.Remove(album);
                db.SaveChanges();
            }
        }
    }
}
