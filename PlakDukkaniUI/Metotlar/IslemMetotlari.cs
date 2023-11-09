using System.Text.RegularExpressions;

namespace PlakDukkaniUI.Metotlar
{
    public static class IslemMetotlari
    {
        /// <summary>
        /// Form kontrollerinde doner ve ilgili alanları temizler.
        /// </summary>
        /// <param name="koleksiyon"></param>
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (var item in koleksiyon)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is DataGridView)
                {
                    ((DataGridView)item).ClearSelection();
                }
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
            }
        }

        /// <summary>
        /// Form kontrollerinde doner ve ilgili alanlar bossa true, doluysa false doner
        /// </summary>
        /// <param name="koleksiyon"></param>
        /// <returns></returns>
        public static bool BosAlanVarMi(Control.ControlCollection koleksiyon)
        {
            bool sonuc = false;
            foreach (var item in koleksiyon)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Name != "txtIndirim")
                    {
                        sonuc = ((TextBox)item).Text == string.Empty ? true : false;
                    }
                }
                if (item is DateTimePicker)
                {
                    sonuc = ((DateTimePicker)item).Value == DateTime.Now ? true : false;
                }

                if (sonuc)
                    break;
            }
            return sonuc;
        }

        /// <summary>
        /// Kullanici sifresini kabul kriterlerine gore kontrol eder
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public static bool SifreKontrol(string sifre)
        {
            if (sifre.Length < 8)
            {
                return false;
            }
            if (Regex.Matches(sifre, @"[A-Z]").Count < 2)
            {
                return false;
            }
            if (Regex.Matches(sifre, @"[!\*\+\:]").Count < 2)
            {
                return false;
            }
            if (Regex.Matches(sifre, @"[a-z]").Count < 3)
            {
                return false;
            }

            return true;
        }
    }
}
