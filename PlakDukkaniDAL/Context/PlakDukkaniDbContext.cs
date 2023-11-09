using Microsoft.EntityFrameworkCore;
using PlakDukkaniDAL.Config;
using PlakDukkaniDATA.Entities;

namespace PlakDukkaniDAL.Context
{
    public class PlakDukkaniDbContext : DbContext
    {
        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<Album> Albumler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Localhost;Initial Catalog=PlakDukkaniDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
            new Album() { Id = 1, Ad = "Mançoloji", Sanatci = "Barış Manço", CikisTarihi = new DateTime(1997, 1, 1), Fiyat = 250, IndirimOrani = 20, SatisDevamMi = true },
            new Album() { Id = 2, Ad = "Gülümse", Sanatci = "Sezen Aksu", CikisTarihi = new DateTime(1981, 1, 1), Fiyat = 230, IndirimOrani = 0, SatisDevamMi = false },
            new Album() { Id = 3, Ad = "Dil Yarası", Sanatci = "Orhan Gencebay", CikisTarihi = new   DateTime(1975, 1, 1), Fiyat = 200, IndirimOrani = 10, SatisDevamMi = false },
            new Album() { Id = 4, Ad = "Ölürüm Sana", Sanatci = "Tarkan", CikisTarihi = new     DateTime    (1997, 1, 1), Fiyat = 280, IndirimOrani = 0, SatisDevamMi = true },
            new Album() { Id = 5, Ad = "O", Sanatci = "Teoman", CikisTarihi = new DateTime(1996, 1,  1),  Fiyat = 210, IndirimOrani = 25, SatisDevamMi = true },
            new Album() { Id = 6, Ad = "Ajda'97", Sanatci = "Ajda Pekkan", CikisTarihi = new    DateTime   (1997, 1, 1), Fiyat = 300, IndirimOrani = 25, SatisDevamMi = false },
            new Album() { Id = 7, Ad = "Mavi Mavi", Sanatci = "İbrahim Tatlıses", CikisTarihi = new      DateTime(1983, 1, 1), Fiyat = 300, IndirimOrani = 0, SatisDevamMi = false },
            new Album() { Id = 8, Ad = "Gülümse (Yeşilçam Şarkıları)", Sanatci = "Sezen Aksu",      CikisTarihi = new DateTime(1994, 1, 1), Fiyat = 250, IndirimOrani = 0, SatisDevamMi =       true },
            new Album() { Id = 9, Ad = "Kenan Doğulu 2", Sanatci = "Kenan Doğulu", CikisTarihi =    new    DateTime(1994, 1, 1), Fiyat = 250, IndirimOrani = 10, SatisDevamMi = false },
            new Album() { Id = 10, Ad = "Sakla Samanı Gelir Zamanı", Sanatci = "Barış Manço",       CikisTarihi = new DateTime(1979, 1, 1), Fiyat = 210, IndirimOrani = 10, SatisDevamMi = false }
           );

            modelBuilder.ApplyConfiguration(new YoneticiConfig())
                        .ApplyConfiguration(new AlbumConfig());
        }
    }
}
