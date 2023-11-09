using PlakDukkaniDATA.Dtos;
using PlakDukkaniDATA.Entities;

namespace PlakDukkaniDAL.Interfaces
{
    public interface IAlbumDAL:IBaseDAL<Album>
    {
        List<AlbumDto> EnYeniAlbumGetir(int adet);
        List<AlbumDto> SatisDevamMiyaGoreGetir(bool satisDevamMi);
        List<AlbumDto> IndirimlileriGetir();
        void Sil(Album album);
    }
}
