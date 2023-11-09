using PlakDukkaniDATA.Entities;
using System.Linq.Expressions;

namespace PlakDukkaniDAL.Interfaces
{
    public interface IYoneticiDAL:IBaseDAL<Yonetici>
    {
        bool AdSifreKontrolu(string ad, string sifre);
        bool AdSifreKontrolu(string ad);
    }
}
