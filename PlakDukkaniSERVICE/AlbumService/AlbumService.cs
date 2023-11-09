using PlakDukkaniDAL.Concretes;
using PlakDukkaniDATA.Dtos;
using PlakDukkaniDATA.Entities;
using System.Linq.Expressions;

namespace PlakDukkaniSERVICE.AlbumService
{
    public class AlbumService : IAlbumService
    {
        AlbumDAL albumDal = new AlbumDAL();
        public void Ekle(Album album)
        {
            albumDal.Ekle(album);
        }

        public List<AlbumDto> EnYeniAlbumGetir(int adet)
        {
            return albumDal.EnYeniAlbumGetir(adet);
        }

        public void Guncelle(Album Album)
        {
            albumDal.Guncelle(Album);
        }

        public Album IdyeGoreGetir(int id)
        {
            return albumDal.IdyeGoreGetir(id);
        }

        public List<Album> KosulaGoreGetir(Expression<Func<Album, bool>> expression)
        {
            return albumDal.KosulaGoreGetir(expression);
        }

        public void Sil(Album Album)
        {
            albumDal.Sil(Album);
        }

        public List<Album> TumunuGetir()
        {
            return albumDal.TumunuGetir();
        }

        public List<AlbumDto> SatisDevamMiyaGoreGetir(bool satisDevamEdiyorMu)
        {
            return albumDal.SatisDevamMiyaGoreGetir(satisDevamEdiyorMu);
        }

        public List<AlbumDto> IndirimlileriGetir()
        {
            return albumDal.IndirimlileriGetir();
        }
    }
}
