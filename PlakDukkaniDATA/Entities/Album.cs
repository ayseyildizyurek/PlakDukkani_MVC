using PlakDukkaniDATA.Abstracts;
using System.ComponentModel;

namespace PlakDukkaniDATA.Entities
{
    public class Album:BaseEntity
    {
        [DisplayName("Album Adı")]
        public string Ad { get; set; }
		[DisplayName("Sanatçı")]
		public string Sanatci { get; set; }
		[DisplayName("Çıkış Tarihi")]
		public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
		[DisplayName("İndirim Oranı")]
		public decimal? IndirimOrani { get; set; }
		[DisplayName("Satışta Mı?")]
		public bool SatisDevamMi { get; set; }
    }
}
