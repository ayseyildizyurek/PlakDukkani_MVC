using Microsoft.AspNetCore.Mvc;
using PlakDukkaniMVCUI.Models.ViewModels;
using PlakDukkaniSERVICE.AlbumService;

namespace PlakDukkaniMVCUI.Controllers
{
	public class AlbumController : Controller
	{
		private readonly IAlbumService albumService = new AlbumService();
		AlbumListeModelView model = new AlbumListeModelView();

		public IActionResult Liste()
		{
			model.Albumler = albumService.TumunuGetir();
			return View(model);
		}

		public IActionResult AlbumFiltreliListe(string filterValue = "", string filterText = "")
		{
			if (filterValue == "" || filterValue == "0")
			{
				model.Albumler = albumService.TumunuGetir();
			}
			else if (filterValue == "1")
			{
				model.AlbumDtos = albumService.SatisDevamMiyaGoreGetir(false);
			}
			else if (filterValue == "2")
			{
				model.AlbumDtos = albumService.SatisDevamMiyaGoreGetir(true);
			}
			else if (filterValue == "3")
			{
				model.AlbumDtos = albumService.IndirimlileriGetir();
			}

			if (filterText != "")
			{
				if (model.AlbumDtos == null)
				{
					model.Albumler = model.Albumler.Where(x => x.Ad.Contains(filterText)).ToList();
				}
				else
				{
					model.AlbumDtos = model.AlbumDtos.Where(x => x.Ad.Contains(filterText)).ToList();
				}
			}

			return PartialView(model);
		}

		public IActionResult AlbumEkleDuzenle(int id = default)
		{
			if (id == default)
			{
				return View(model);
			}
			else
			{
				model.Album = albumService.IdyeGoreGetir(id);
				return View(model);
			}
		}

		[HttpPost]
		public IActionResult AlbumEkleDuzenle(AlbumListeModelView model, int id)
		{
			if (id == default)
			{
				albumService.Ekle(model.Album);
				TempData["mesaj"] = "Kayıt başarılı";
			}
			else
			{
				var guncellenecekAlbum = albumService.IdyeGoreGetir(id);
				guncellenecekAlbum.Ad = model.Album.Ad;
				guncellenecekAlbum.SatisDevamMi = model.Album.SatisDevamMi;
				guncellenecekAlbum.Fiyat = model.Album.Fiyat;
				guncellenecekAlbum.CikisTarihi = model.Album.CikisTarihi;
				guncellenecekAlbum.IndirimOrani = model.Album.IndirimOrani;
				guncellenecekAlbum.Sanatci = model.Album.Sanatci;
				guncellenecekAlbum.GuncellemeTarihi = DateTime.Now;
				albumService.Guncelle(guncellenecekAlbum);
				TempData["mesaj"] = "Güncelleme başarılı";
			}


			return RedirectToAction("Liste");
		}

		public IActionResult Detaylar(int id)
		{
			model.Album = albumService.IdyeGoreGetir(id);
			return View(model);
		}

		public IActionResult Sil(int id)
		{
			model.Album = albumService.IdyeGoreGetir(id);
			albumService.Sil(model.Album);
			TempData["mesaj"] = "Silme başarılı";
			return RedirectToAction("Liste");
		}
	}
}
