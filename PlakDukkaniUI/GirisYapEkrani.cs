using PlakDukkaniSERVICE.HataMesajlari;
using PlakDukkaniSERVICE.YoneticiService;
using PlakDukkaniUI.Metotlar;

namespace PlakDukkaniUI
{
    public partial class GirisYapEkrani : Form
    {
        YoneticiService yoneticiService = new YoneticiService();
        public GirisYapEkrani()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!IslemMetotlari.BosAlanVarMi(this.Controls))
            {
                if (yoneticiService.AdSifreKontrolu(txtKullaniciAd.Text.Trim(), txtSifre.Text.Trim()))
                {
                    AlbumPaneli albumEkrani = new AlbumPaneli();
                    albumEkrani.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(HataveBilgiMesajlari.GecersizKullaniciSifreHatasi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show(HataveBilgiMesajlari.BosAlanHatasi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            KaydolEkrani kaydolEkrani = new KaydolEkrani();
            kaydolEkrani.Show();
            this.Hide();
        }

        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chkSifreyiGoster.Checked ? '\0' : '*';
        }

        private void GirisYapEkrani_Load(object sender, EventArgs e)
        {
        }
    }
}
