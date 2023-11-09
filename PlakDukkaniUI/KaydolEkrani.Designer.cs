namespace PlakDukkaniUI
{
    partial class KaydolEkrani
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
            btnGeri = new Button();
            btnKaydol = new Button();
            txtSifre = new TextBox();
            lblSifre = new Label();
            txtKullaniciAd = new TextBox();
            lblKullaniciAd = new Label();
            lblSifreTekrar = new Label();
            txtSifreTekrar = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            SuspendLayout();
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkSifreyiGoster.Location = new Point(201, 289);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(103, 19);
            chkSifreyiGoster.TabIndex = 14;
            chkSifreyiGoster.Text = "Şifreyi Göster";
            chkSifreyiGoster.UseVisualStyleBackColor = true;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // btnGeri
            // 
            btnGeri.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = SystemColors.ControlDarkDark;
            btnGeri.Location = new Point(12, 346);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(65, 38);
            btnGeri.TabIndex = 12;
            btnGeri.Text = "<<<";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnKaydol
            // 
            btnKaydol.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydol.ForeColor = SystemColors.ControlDarkDark;
            btnKaydol.Location = new Point(216, 346);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(105, 38);
            btnKaydol.TabIndex = 13;
            btnKaydol.Text = "Kaydol";
            btnKaydol.UseVisualStyleBackColor = true;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.ForeColor = SystemColors.WindowFrame;
            txtSifre.Location = new Point(201, 201);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(192, 27);
            txtSifre.TabIndex = 9;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.DimGray;
            lblSifre.BorderStyle = BorderStyle.Fixed3D;
            lblSifre.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.ForeColor = Color.White;
            lblSifre.Location = new Point(154, 204);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(43, 22);
            lblSifre.TabIndex = 10;
            lblSifre.Text = "Şifre";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAd.ForeColor = SystemColors.WindowFrame;
            txtKullaniciAd.Location = new Point(201, 110);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(192, 27);
            txtKullaniciAd.TabIndex = 8;
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.BackColor = Color.DimGray;
            lblKullaniciAd.BorderStyle = BorderStyle.Fixed3D;
            lblKullaniciAd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAd.ForeColor = Color.White;
            lblKullaniciAd.Location = new Point(99, 110);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(98, 22);
            lblKullaniciAd.TabIndex = 11;
            lblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.BackColor = Color.DimGray;
            lblSifreTekrar.BorderStyle = BorderStyle.Fixed3D;
            lblSifreTekrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifreTekrar.ForeColor = Color.White;
            lblSifreTekrar.Location = new Point(106, 249);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(91, 22);
            lblSifreTekrar.TabIndex = 10;
            lblSifreTekrar.Text = "Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifreTekrar.ForeColor = SystemColors.WindowFrame;
            txtSifreTekrar.Location = new Point(201, 244);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(192, 27);
            txtSifreTekrar.TabIndex = 9;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.DimGray;
            lblTitle.BorderStyle = BorderStyle.Fixed3D;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(141, 154);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(56, 22);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Unvan";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.ForeColor = SystemColors.WindowFrame;
            txtTitle.Location = new Point(201, 154);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(192, 27);
            txtTitle.TabIndex = 8;
            // 
            // KaydolEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.siyahbeyaz;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(543, 409);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(btnGeri);
            Controls.Add(btnKaydol);
            Controls.Add(txtSifreTekrar);
            Controls.Add(lblSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(txtKullaniciAd);
            Controls.Add(lblKullaniciAd);
            Name = "KaydolEkrani";
            Text = "KaydolEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkSifreyiGoster;
        private Button btnGeri;
        private Button btnKaydol;
        private TextBox txtSifre;
        private Label lblSifre;
        private TextBox txtKullaniciAd;
        private Label lblKullaniciAd;
        private Label lblSifreTekrar;
        private TextBox txtSifreTekrar;
        private Label lblTitle;
        private TextBox txtTitle;
    }
}