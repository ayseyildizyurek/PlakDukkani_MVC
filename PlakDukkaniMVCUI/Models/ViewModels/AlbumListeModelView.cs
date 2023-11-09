using Microsoft.AspNetCore.Mvc.Rendering;
using PlakDukkaniDATA.Dtos;
using PlakDukkaniDATA.Entities;

namespace PlakDukkaniMVCUI.Models.ViewModels
{
    public class AlbumListeModelView
    {
        public List<Album> Albumler { get; set; }
        public Album Album { get; set; }

		public List<SelectListItem> Filtre = new List<SelectListItem>()
		{
			new SelectListItem(){Text="Tümünü Getir", Value="0"},
			new SelectListItem(){Text="Satışı Duran Albümler", Value="1"},
			new SelectListItem(){Text="Satışı Devam Eden Albümler", Value="2"},
			new SelectListItem(){Text="İndirimli Albümler", Value="3"}
		};

        public List<AlbumDto> AlbumDtos { get; set; }
    }
}
