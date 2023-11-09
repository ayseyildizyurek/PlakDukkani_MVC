using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDukkaniDATA.Entities;

namespace PlakDukkaniDAL.Config
{
    public class YoneticiConfig : IEntityTypeConfiguration<Yonetici>
    {
        public void Configure(EntityTypeBuilder<Yonetici> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Kullanicilar");
            builder.Property(x => x.Id).HasColumnOrder(1);
            builder.HasIndex(x => x.Ad).IsUnique();
            builder.Property(x => x.Ad).HasColumnName("KullaniciAdi").HasColumnType("nvarchar").HasMaxLength(100).IsRequired().HasColumnOrder(2);
            builder.Property(x => x.Sifre).HasColumnName("Sifre").IsRequired().HasColumnOrder(3);
            builder.Property(x => x.Title).HasColumnName("Unvan").HasColumnType("nvarchar").HasMaxLength(100).IsRequired(false).HasColumnOrder(4);
            builder.Property(x => x.KayitTarihi).HasColumnName("KayitTarihi").HasColumnType("date").HasColumnOrder(5);
            builder.Property(x => x.GuncellemeTarihi).HasColumnName("GuncellemeTarihi").HasColumnType("date").HasColumnOrder(6);
        }
    }
}
