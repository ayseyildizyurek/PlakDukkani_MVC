using PlakDukkaniDATA.Abstracts;
using System.Linq.Expressions;

namespace PlakDukkaniDAL.Interfaces
{
    public interface IBaseDAL<T> where T : BaseEntity
    {
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(T entity);
        T IdyeGoreGetir(int id);
        List<T> TumunuGetir();
        List<T> KosulaGoreGetir(Expression<Func<T, bool>> expression);
    }
}
