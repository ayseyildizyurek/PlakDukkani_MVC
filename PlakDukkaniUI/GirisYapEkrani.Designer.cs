namespace PlakDukkaniUI
{
    partial class GirisYapEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkSifreyiGoster = new CheckBox();
            btnKaydol = new Button();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            lblSifre = new Label();
            txtKullaniciAd = new TextBox();
            lblKullaniciAd = new Label();
            SuspendLayout();
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkSifreyiGoster.Location = new Point(168, 325);
            chkSifreyiGoster.Margin = new Padding(3, 4, 3, 4);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(126, 24);
            chkSifreyiGoster.TabIndex = 15;
            chkSifreyiGoster.Text = "Şifreyi Göster";
            chkSifreyiGoster.UseVisualStyleBackColor = true;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // btnKaydol
            // 
            btnKaydol.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydol.ForeColor = SystemColors.ControlDarkDark;
            btnKaydol.Location = new Point(191, 513);
            btnKaydol.Margin = new Padding(3, 4, 3, 4);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(192, 51);
            btnKaydol.TabIndex = 12;
            btnKaydol.Text = "Kaydol";
            btnKaydol.UseVisualStyleBackColor = true;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.ForeColor = SystemColors.ControlDarkDark;
            btnGirisYap.Location = new Point(191, 455);
            btnGirisYap.Margin = new Padding(3, 4, 3, 4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(192, 51);
            btnGirisYap.TabIndex = 13;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.ForeColor = SystemColors.WindowFrame;
            txtSifre.Location = new Point(222, 268);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(219, 32);
            txtSifre.TabIndex = 14;
            txtSifre.Text = "AAdmin123**";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.DimGray;
            lblSifre.BorderStyle = BorderStyle.Fixed3D;
            lblSifre.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.ForeColor = Color.White;
            lblSifre.Location = new Point(168, 272);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(55, 27);
            lblSifre.TabIndex = 9;
            lblSifre.Text = "Şifre";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAd.ForeColor = SystemColors.WindowFrame;
            txtKullaniciAd.Location = new Point(222, 208);
            txtKullaniciAd.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(219, 32);
            txtKullaniciAd.TabIndex = 11;
            txtKullaniciAd.Text = "admin5";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.BackColor = Color.DimGray;
            lblKullaniciAd.BorderStyle = BorderStyle.Fixed3D;
            lblKullaniciAd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAd.ForeColor = Color.White;
            lblKullaniciAd.Location = new Point(105, 208);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(124, 27);
            lblKullaniciAd.TabIndex = 10;
            lblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // GirisYapEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.siyahbeyaz;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(565, 583);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(btnKaydol);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtKullaniciAd);
            Controls.Add(lblKullaniciAd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GirisYapEkrani";
            Text = "GirisYapEkrani";
            Load += GirisYapEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkSifreyiGoster;
        private Button btnKaydol;
        private Button btnGirisYap;
        private TextBox txtSifre;
        private Label lblSifre;
        private TextBox txtKullaniciAd;
        private Label lblKullaniciAd;
    }
}