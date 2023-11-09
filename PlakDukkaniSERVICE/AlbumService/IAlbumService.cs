using PlakDukkaniDATA.Dtos;
using PlakDukkaniDATA.Entities;
using System.Linq.Expressions;

namespace PlakDukkaniSERVICE.AlbumService
{
    public interface IAlbumService
    {
        void Ekle(Album album);
        void Guncelle(Album album);
        void Sil(Album album);
        Album IdyeGoreGetir(int id);
        List<Album> TumunuGetir();
        List<Album> KosulaGoreGetir(Expression<Func<Album, bool>> expression);
        List<AlbumDto> EnYeniAlbumGetir(int adet);
        List<AlbumDto> SatisDevamMiyaGoreGetir(bool satisDevamEdiyorMu);
        List<AlbumDto> IndirimlileriGetir();
    }
}
