using PlakDukkaniDATA.Entities;
using PlakDukkaniSERVICE.HataMesajlari;
using PlakDukkaniSERVICE.YoneticiService;
using PlakDukkaniUI.Metotlar;

namespace PlakDukkaniUI
{
    public partial class KaydolEkrani : Form
    {
        public KaydolEkrani()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            YoneticiService yoneticiService = new YoneticiService();
            try
            {
                if (!IslemMetotlari.BosAlanVarMi(this.Controls))
                {
                    if (txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim())
                    {
                        if (yoneticiService.AdSifreKontrolu(txtKullaniciAd.Text.Trim()))
                        {
                            MessageBox.Show(HataveBilgiMesajlari.GecersizKullaniciAdiHatasi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (!IslemMetotlari.SifreKontrol(txtSifre.Text.Trim()))
                            {
                                MessageBox.Show(HataveBilgiMesajlari.GecersizSifreHatasi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                yonetici.Ad = txtKullaniciAd.Text.Trim();
                                yonetici.Title = txtTitle.Text.Trim();
                                yonetici.Sifre = SifrelemeIslemleri.Sifrele(txtSifre.Text.Trim(), yonetici.Ad);

                                yoneticiService.Ekle(yonetici);

                                MessageBox.Show(HataveBilgiMesajlari.KaydedildiBilgisi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                GirisYapEkrani girisYapEkrani = new GirisYapEkrani();
                                girisYapEkrani.Show();
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(HataveBilgiMesajlari.SifreEslesmemeHatasi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(HataveBilgiMesajlari.BosAlanHatasi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(HataveBilgiMesajlari.CrudHatalari, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chkSifreyiGoster.Checked ? '\0' : '*';
            txtSifreTekrar.PasswordChar = chkSifreyiGoster.Checked ? '\0' : '*';
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisYapEkrani girisYapEkrani = new GirisYapEkrani();
            girisYapEkrani.Show();
            this.Close();
        }
    }
}
