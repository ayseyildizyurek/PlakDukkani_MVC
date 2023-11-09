using PlakDukkaniDATA.Entities;
using PlakDukkaniSERVICE.AlbumService;
using PlakDukkaniSERVICE.HataMesajlari;
using PlakDukkaniUI.Metotlar;

namespace PlakDukkaniUI
{
    public partial class AlbumPaneli : Form
    {
        AlbumService albumService = new AlbumService();
        Album album;
        Album seciliAlbum;
        decimal deger = 0;
        public AlbumPaneli()
        {
            InitializeComponent();
        }

        private void DGVFill<T>(List<T> albumListe)
        {
            dgvAlbum.DataSource = albumListe;
            dgvAlbum.ClearSelection();

        }

        private void Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                switch (btn.Tag)
                {
                    case "1": DGVFill(albumService.TumunuGetir()); break;
                    case "2": DGVFill(albumService.SatisDevamMiyaGoreGetir(false)); break;
                    case "3": DGVFill(albumService.SatisDevamMiyaGoreGetir(true)); break;
                    case "4": DGVFill(albumService.EnYeniAlbumGetir(10)); break;
                    case "5": DGVFill(albumService.IndirimlileriGetir()); break;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (IslemMetotlari.BosAlanVarMi(this.Controls))
                {
                    MessageBox.Show(HataveBilgiMesajlari.BosAlanHatasi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string indirimText = txtIndirim.Text.Trim();

                    decimal indirimOrani = decimal.TryParse(indirimText, out deger) ? deger : 0;

                    album = new Album()
                    {
                        Ad = txtAlbumAd.Text.Trim(),
                        Sanatci = txtMuzisyen.Text.Trim(),
                        CikisTarihi = dtpCikisTarihi.Value,
                        Fiyat = Convert.ToDecimal(txtFiyat.Text.Trim()),
                        IndirimOrani = indirimOrani,
                        SatisDevamMi = rdbAktif.Checked
                    };


                    albumService.Ekle(album);
                    MessageBox.Show(HataveBilgiMesajlari.KaydedildiBilgisi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVFill(albumService.TumunuGetir());
                    IslemMetotlari.Temizle(this.Controls);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(HataveBilgiMesajlari.CrudHatalari, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (IslemMetotlari.BosAlanVarMi(this.Controls))
                {
                    MessageBox.Show(HataveBilgiMesajlari.BosAlanHatasi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string indirimText = txtIndirim.Text.Trim();

                    decimal indirimOrani = decimal.TryParse(indirimText, out deger) ? deger : 0;
                    seciliAlbum.Ad = txtAlbumAd.Text.Trim();
                    seciliAlbum.Sanatci = txtMuzisyen.Text.Trim();
                    seciliAlbum.CikisTarihi = dtpCikisTarihi.Value;
                    seciliAlbum.Fiyat = Convert.ToDecimal(txtFiyat.Text.Trim());
                    seciliAlbum.IndirimOrani = deger;
                    seciliAlbum.SatisDevamMi = rdbAktif.Checked == true ? true : false;

                    albumService.Guncelle(seciliAlbum);
                    MessageBox.Show(HataveBilgiMesajlari.GuncellendiBilgisi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVFill(albumService.TumunuGetir());
                    IslemMetotlari.Temizle(this.Controls);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(HataveBilgiMesajlari.CrudHatalari, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvAlbum.SelectedRows[0];
                string columnName = "Id";
                int idValue = Convert.ToInt32(selectedRow.Cells[columnName].Value);
                var seciliAlbum = albumService.IdyeGoreGetir(idValue);

                albumService.Sil(seciliAlbum);
                MessageBox.Show(HataveBilgiMesajlari.SilindiBilgisi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill(albumService.TumunuGetir());
                IslemMetotlari.Temizle(this.Controls);

            }
            catch (Exception)
            {
                MessageBox.Show(HataveBilgiMesajlari.CrudHatalari, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvAlbum_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvAlbum.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAlbum.SelectedRows[0];
                string columnName = "Id";
                int idValue = Convert.ToInt32(selectedRow.Cells[columnName].Value);
                seciliAlbum = albumService.IdyeGoreGetir(idValue);

                txtAlbumAd.Text = seciliAlbum.Ad;
                txtMuzisyen.Text = seciliAlbum.Sanatci;
                dtpCikisTarihi.Value = seciliAlbum.CikisTarihi;
                txtFiyat.Text = seciliAlbum.Fiyat.ToString();
                txtIndirim.Text = seciliAlbum.IndirimOrani.ToString();
                rdbAktif.Checked = seciliAlbum.SatisDevamMi == true ? true : false;
                rdbPasif.Checked = seciliAlbum.SatisDevamMi == true ? false : true;
            }
        }
    }
}
