namespace PlakDukkaniUI
{
    partial class AlbumPaneli
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
            dgvAlbum = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTumunuGoster = new Button();
            btnIndirimli = new Button();
            btnEnYeniOn = new Button();
            btnSatisiDevamEden = new Button();
            btnSatisiDuran = new Button();
            btnEkle = new Button();
            rdbPasif = new RadioButton();
            rdbAktif = new RadioButton();
            dtpCikisTarihi = new DateTimePicker();
            txtIndirim = new TextBox();
            txtFiyat = new TextBox();
            lblSatisDurumu = new Label();
            txtMuzisyen = new TextBox();
            lblIndirim = new Label();
            lblFiyat = new Label();
            lblCikisTarihi = new Label();
            lblMuzisyen = new Label();
            txtAlbumAd = new TextBox();
            lblAlbumListe = new Label();
            lblAlbumAd = new Label();
            panel1 = new Panel();
            lblFiyat2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).BeginInit();
            SuspendLayout();
            // 
            // dgvAlbum
            // 
            dgvAlbum.BackgroundColor = Color.Silver;
            dgvAlbum.BorderStyle = BorderStyle.None;
            dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbum.Location = new Point(389, 36);
            dgvAlbum.Margin = new Padding(3, 4, 3, 4);
            dgvAlbum.MultiSelect = false;
            dgvAlbum.Name = "dgvAlbum";
            dgvAlbum.ReadOnly = true;
            dgvAlbum.RowHeadersWidth = 51;
            dgvAlbum.RowTemplate.Height = 25;
            dgvAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbum.Size = new Size(504, 480);
            dgvAlbum.TabIndex = 35;
            dgvAlbum.MouseClick += dgvAlbum_MouseClick;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = SystemColors.ControlDarkDark;
            btnGuncelle.Location = new Point(151, 441);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(129, 35);
            btnGuncelle.TabIndex = 27;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = SystemColors.ControlDarkDark;
            btnSil.Location = new Point(149, 507);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(129, 35);
            btnSil.TabIndex = 34;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnTumunuGoster
            // 
            btnTumunuGoster.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnTumunuGoster.ForeColor = SystemColors.ControlDarkDark;
            btnTumunuGoster.Location = new Point(904, 112);
            btnTumunuGoster.Margin = new Padding(3, 4, 3, 4);
            btnTumunuGoster.Name = "btnTumunuGoster";
            btnTumunuGoster.Size = new Size(197, 68);
            btnTumunuGoster.TabIndex = 29;
            btnTumunuGoster.Tag = "1";
            btnTumunuGoster.Text = "Tümünü Göster";
            btnTumunuGoster.UseVisualStyleBackColor = true;
            btnTumunuGoster.Click += Click;
            // 
            // btnIndirimli
            // 
            btnIndirimli.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnIndirimli.ForeColor = SystemColors.ControlDarkDark;
            btnIndirimli.Location = new Point(904, 441);
            btnIndirimli.Margin = new Padding(3, 4, 3, 4);
            btnIndirimli.Name = "btnIndirimli";
            btnIndirimli.Size = new Size(197, 68);
            btnIndirimli.TabIndex = 28;
            btnIndirimli.Tag = "5";
            btnIndirimli.Text = "İndirimli Albümler";
            btnIndirimli.UseVisualStyleBackColor = true;
            btnIndirimli.Click += Click;
            // 
            // btnEnYeniOn
            // 
            btnEnYeniOn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnYeniOn.ForeColor = SystemColors.ControlDarkDark;
            btnEnYeniOn.Location = new Point(904, 357);
            btnEnYeniOn.Margin = new Padding(3, 4, 3, 4);
            btnEnYeniOn.Name = "btnEnYeniOn";
            btnEnYeniOn.Size = new Size(197, 68);
            btnEnYeniOn.TabIndex = 33;
            btnEnYeniOn.Tag = "4";
            btnEnYeniOn.Text = "En Yeni 10 Albüm";
            btnEnYeniOn.UseVisualStyleBackColor = true;
            btnEnYeniOn.Click += Click;
            // 
            // btnSatisiDevamEden
            // 
            btnSatisiDevamEden.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSatisiDevamEden.ForeColor = SystemColors.ControlDarkDark;
            btnSatisiDevamEden.Location = new Point(904, 277);
            btnSatisiDevamEden.Margin = new Padding(3, 4, 3, 4);
            btnSatisiDevamEden.Name = "btnSatisiDevamEden";
            btnSatisiDevamEden.Size = new Size(197, 68);
            btnSatisiDevamEden.TabIndex = 32;
            btnSatisiDevamEden.Tag = "3";
            btnSatisiDevamEden.Text = "Satışı Devam Eden Albümler";
            btnSatisiDevamEden.UseVisualStyleBackColor = true;
            btnSatisiDevamEden.Click += Click;
            // 
            // btnSatisiDuran
            // 
            btnSatisiDuran.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSatisiDuran.ForeColor = SystemColors.ControlDarkDark;
            btnSatisiDuran.Location = new Point(904, 196);
            btnSatisiDuran.Margin = new Padding(3, 4, 3, 4);
            btnSatisiDuran.Name = "btnSatisiDuran";
            btnSatisiDuran.Size = new Size(197, 68);
            btnSatisiDuran.TabIndex = 31;
            btnSatisiDuran.Tag = "2";
            btnSatisiDuran.Text = "Satışı Duran Albümler";
            btnSatisiDuran.UseVisualStyleBackColor = true;
            btnSatisiDuran.Click += Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = SystemColors.ControlDarkDark;
            btnEkle.Location = new Point(155, 374);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(129, 35);
            btnEkle.TabIndex = 30;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // rdbPasif
            // 
            rdbPasif.AutoSize = true;
            rdbPasif.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rdbPasif.Location = new Point(255, 311);
            rdbPasif.Margin = new Padding(3, 4, 3, 4);
            rdbPasif.Name = "rdbPasif";
            rdbPasif.Size = new Size(69, 27);
            rdbPasif.TabIndex = 26;
            rdbPasif.TabStop = true;
            rdbPasif.Text = "Pasif";
            rdbPasif.UseVisualStyleBackColor = true;
            // 
            // rdbAktif
            // 
            rdbAktif.AutoSize = true;
            rdbAktif.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAktif.Location = new Point(146, 312);
            rdbAktif.Margin = new Padding(3, 4, 3, 4);
            rdbAktif.Name = "rdbAktif";
            rdbAktif.Size = new Size(72, 27);
            rdbAktif.TabIndex = 21;
            rdbAktif.TabStop = true;
            rdbAktif.Text = "Aktif";
            rdbAktif.UseVisualStyleBackColor = true;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(146, 153);
            dtpCikisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(219, 27);
            dtpCikisTarihi.TabIndex = 15;
            // 
            // txtIndirim
            // 
            txtIndirim.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtIndirim.ForeColor = SystemColors.WindowFrame;
            txtIndirim.Location = new Point(146, 253);
            txtIndirim.Margin = new Padding(3, 4, 3, 4);
            txtIndirim.Name = "txtIndirim";
            txtIndirim.Size = new Size(219, 32);
            txtIndirim.TabIndex = 17;
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiyat.ForeColor = SystemColors.WindowFrame;
            txtFiyat.Location = new Point(146, 207);
            txtFiyat.Margin = new Padding(3, 4, 3, 4);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(219, 32);
            txtFiyat.TabIndex = 16;
            // 
            // lblSatisDurumu
            // 
            lblSatisDurumu.AutoSize = true;
            lblSatisDurumu.BackColor = Color.Transparent;
            lblSatisDurumu.BorderStyle = BorderStyle.Fixed3D;
            lblSatisDurumu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatisDurumu.ForeColor = Color.Black;
            lblSatisDurumu.Location = new Point(10, 312);
            lblSatisDurumu.Name = "lblSatisDurumu";
            lblSatisDurumu.Size = new Size(135, 27);
            lblSatisDurumu.TabIndex = 24;
            lblSatisDurumu.Text = "Satış Durumu";
            // 
            // txtMuzisyen
            // 
            txtMuzisyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMuzisyen.ForeColor = SystemColors.WindowFrame;
            txtMuzisyen.Location = new Point(146, 96);
            txtMuzisyen.Margin = new Padding(3, 4, 3, 4);
            txtMuzisyen.Name = "txtMuzisyen";
            txtMuzisyen.Size = new Size(219, 32);
            txtMuzisyen.TabIndex = 14;
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.BackColor = Color.Transparent;
            lblIndirim.BorderStyle = BorderStyle.Fixed3D;
            lblIndirim.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblIndirim.ForeColor = Color.Black;
            lblIndirim.Location = new Point(10, 260);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new Size(133, 27);
            lblIndirim.TabIndex = 25;
            lblIndirim.Text = "İndirim Oranı";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.BackColor = Color.Transparent;
            lblFiyat.BorderStyle = BorderStyle.Fixed3D;
            lblFiyat.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyat.ForeColor = Color.Black;
            lblFiyat.Location = new Point(-78, 185);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(56, 27);
            lblFiyat.TabIndex = 23;
            lblFiyat.Text = "Fiyat";
            // 
            // lblCikisTarihi
            // 
            lblCikisTarihi.AutoSize = true;
            lblCikisTarihi.BackColor = Color.Transparent;
            lblCikisTarihi.BorderStyle = BorderStyle.Fixed3D;
            lblCikisTarihi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCikisTarihi.ForeColor = Color.Black;
            lblCikisTarihi.Location = new Point(10, 153);
            lblCikisTarihi.Name = "lblCikisTarihi";
            lblCikisTarihi.Size = new Size(108, 27);
            lblCikisTarihi.TabIndex = 20;
            lblCikisTarihi.Text = "Çıkış Tarihi";
            // 
            // lblMuzisyen
            // 
            lblMuzisyen.AutoSize = true;
            lblMuzisyen.BackColor = Color.Transparent;
            lblMuzisyen.BorderStyle = BorderStyle.Fixed3D;
            lblMuzisyen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMuzisyen.ForeColor = Color.Black;
            lblMuzisyen.Location = new Point(10, 96);
            lblMuzisyen.Name = "lblMuzisyen";
            lblMuzisyen.Size = new Size(98, 27);
            lblMuzisyen.TabIndex = 19;
            lblMuzisyen.Text = "Müzisyen";
            // 
            // txtAlbumAd
            // 
            txtAlbumAd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlbumAd.ForeColor = SystemColors.WindowFrame;
            txtAlbumAd.Location = new Point(146, 36);
            txtAlbumAd.Margin = new Padding(3, 4, 3, 4);
            txtAlbumAd.Name = "txtAlbumAd";
            txtAlbumAd.Size = new Size(219, 32);
            txtAlbumAd.TabIndex = 13;
            // 
            // lblAlbumListe
            // 
            lblAlbumListe.BackColor = Color.Transparent;
            lblAlbumListe.BorderStyle = BorderStyle.Fixed3D;
            lblAlbumListe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbumListe.ForeColor = Color.Black;
            lblAlbumListe.Location = new Point(948, 36);
            lblAlbumListe.Name = "lblAlbumListe";
            lblAlbumListe.Size = new Size(123, 56);
            lblAlbumListe.TabIndex = 18;
            lblAlbumListe.Text = "Albümler";
            lblAlbumListe.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAlbumAd
            // 
            lblAlbumAd.AutoSize = true;
            lblAlbumAd.BackColor = Color.Transparent;
            lblAlbumAd.BorderStyle = BorderStyle.Fixed3D;
            lblAlbumAd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbumAd.ForeColor = Color.Black;
            lblAlbumAd.Location = new Point(10, 36);
            lblAlbumAd.Name = "lblAlbumAd";
            lblAlbumAd.Size = new Size(108, 27);
            lblAlbumAd.TabIndex = 22;
            lblAlbumAd.Text = "Albüm Adı";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.notalar1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 578);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 183);
            panel1.TabIndex = 12;
            // 
            // lblFiyat2
            // 
            lblFiyat2.AutoSize = true;
            lblFiyat2.BackColor = Color.Transparent;
            lblFiyat2.BorderStyle = BorderStyle.Fixed3D;
            lblFiyat2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyat2.ForeColor = Color.Black;
            lblFiyat2.Location = new Point(10, 207);
            lblFiyat2.Name = "lblFiyat2";
            lblFiyat2.Size = new Size(56, 27);
            lblFiyat2.TabIndex = 20;
            lblFiyat2.Text = "Fiyat";
            // 
            // AlbumPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1114, 761);
            Controls.Add(dgvAlbum);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnTumunuGoster);
            Controls.Add(btnIndirimli);
            Controls.Add(btnEnYeniOn);
            Controls.Add(btnSatisiDevamEden);
            Controls.Add(btnSatisiDuran);
            Controls.Add(btnEkle);
            Controls.Add(rdbPasif);
            Controls.Add(rdbAktif);
            Controls.Add(dtpCikisTarihi);
            Controls.Add(txtIndirim);
            Controls.Add(txtFiyat);
            Controls.Add(lblSatisDurumu);
            Controls.Add(txtMuzisyen);
            Controls.Add(lblIndirim);
            Controls.Add(lblFiyat);
            Controls.Add(lblFiyat2);
            Controls.Add(lblCikisTarihi);
            Controls.Add(lblMuzisyen);
            Controls.Add(txtAlbumAd);
            Controls.Add(lblAlbumListe);
            Controls.Add(lblAlbumAd);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AlbumPaneli";
            Text = "AlbumPaneli";
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlbum;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTumunuGoster;
        private Button btnIndirimli;
        private Button btnEnYeniOn;
        private Button btnSatisiDevamEden;
        private Button btnSatisiDuran;
        private Button btnEkle;
        private RadioButton rdbPasif;
        private RadioButton rdbAktif;
        private DateTimePicker dtpCikisTarihi;
        private TextBox txtIndirim;
        private TextBox txtFiyat;
        private Label lblSatisDurumu;
        private TextBox txtMuzisyen;
        private Label lblIndirim;
        private Label lblFiyat;
        private Label lblCikisTarihi;
        private Label lblMuzisyen;
        private TextBox txtAlbumAd;
        private Label lblAlbumListe;
        private Label lblAlbumAd;
        private Panel panel1;
        private Label lblFiyat2;
    }
}