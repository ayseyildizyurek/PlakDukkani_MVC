using PlakDukkaniDATA.Abstracts;

namespace PlakDukkaniDATA.Entities
{
    public class Yonetici : BaseEntity
    {
        public string Ad { get; set; }
        public string Sifre { get; set; }
        public string? Title { get; set; }
    }
}
