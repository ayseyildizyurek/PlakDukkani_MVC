using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDukkaniDATA.Entities;

namespace PlakDukkaniDAL.Config
{
    public class AlbumConfig : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Albumler");
            builder.Property(x => x.Id).HasColumnOrder(1);
            builder.Property(x => x.Ad).HasColumnName("AlbumAdi").HasColumnType("nvarchar").HasMaxLength(100).IsRequired().HasColumnOrder(2);
            builder.Property(x => x.Sanatci).HasColumnName("SanatciAdi").HasColumnType("nvarchar").HasMaxLength(100).IsRequired().HasColumnOrder(3);
            builder.Property(x => x.CikisTarihi).HasColumnName("CikisTarihi").HasColumnType("date").IsRequired().HasColumnOrder(4);
            builder.Property(x => x.Fiyat).HasColumnName("Fiyat").HasColumnType("decimal(18,2)").IsRequired().HasColumnOrder(5);
            builder.Property(x => x.IndirimOrani).HasColumnName("IndirimOrani").HasColumnType("decimal(18,0)").IsRequired(false).HasColumnOrder(6);
            builder.Property(x => x.SatisDevamMi).HasColumnName("SatisAktifMi").HasColumnType("bit").IsRequired().HasColumnOrder(7);
            builder.Property(x => x.KayitTarihi).HasColumnName("KayitTarihi").HasColumnType("date").HasColumnOrder(8);
            builder.Property(x => x.GuncellemeTarihi).HasColumnName("GuncellemeTarihi").HasColumnType("date").IsRequired(false).HasColumnOrder(9);
        }
    }
}
