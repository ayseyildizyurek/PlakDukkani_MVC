using PlakDukkaniDAL.Context;
using PlakDukkaniDAL.Interfaces;
using PlakDukkaniDATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniDAL.Concretes
{
    public class BaseDal<T> : IBaseDAL<T> where T : BaseEntity
    {
        PlakDukkaniDbContext db;
        /// <summary>
        /// Veritabanına parametreden gelen entityi ekler ve kaydeder.
        /// </summary>
        /// <param name="entity"></param>
        public void Ekle(T entity)
        {
            using (db = new PlakDukkaniDbContext())
            {
                db.Add(entity);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Veritabanında parametreden gelen entityi gunceller ve kaydeder.
        /// </summary>
        /// <param name="entity"></param>
        public void Guncelle(T entity)
        {
            using (db = new PlakDukkaniDbContext())
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Veritabanında parametreden gelen idye gore entityi getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T IdyeGoreGetir(int id)
        {
            using (db = new PlakDukkaniDbContext())
            {
                return db.Set<T>().Find(id);
            }
        }

        /// <summary>
        /// parametreden gelen koşula göre entity listesi döndürür.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public List<T> KosulaGoreGetir(Expression<Func<T, bool>> expression)
        {
            using (db = new PlakDukkaniDbContext())
            {
                return db.Set<T>().Where(expression).ToList();
            }
        }

        /// <summary>
        /// Veritabanında parametreden gelen entityi siler.
        /// </summary>
        /// <param name="entity"></param>
        public void Sil(T entity)
        {
            using (db = new PlakDukkaniDbContext())
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Veritabanındaki entityleri liste olarak getirir.
        /// </summary>
        /// <returns></returns>
        public List<T> TumunuGetir()
        {
            using (db = new PlakDukkaniDbContext())
            {
                return db.Set<T>().ToList();
            }
        }
    }
}
