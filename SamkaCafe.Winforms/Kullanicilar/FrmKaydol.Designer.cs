namespace SamkaCafe.Winforms.Kullanicilar
{
    partial class FrmKaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaydol));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.toggleAktifmi = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textTelefon = new DevExpress.XtraEditors.TextEdit();
            this.memoAdres = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textGorevi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textParola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textParolaSorusu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.textCevap = new DevExpress.XtraEditors.TextEdit();
            this.memoAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleAktifmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGorevi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParolaTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParolaSorusu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(367, 35);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Kullanıcı Kayıt";
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.Location = new System.Drawing.Point(114, 85);
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(213, 20);
            this.textAdSoyad.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 28);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Ad Soyad :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 490);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(367, 100);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "İŞLEMLER";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(267, 42);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 46);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(12, 42);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(108, 46);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // toggleAktifmi
            // 
            this.toggleAktifmi.Location = new System.Drawing.Point(114, 59);
            this.toggleAktifmi.Name = "toggleAktifmi";
            this.toggleAktifmi.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.toggleAktifmi.Properties.OffText = "Aktif Değil";
            this.toggleAktifmi.Properties.OnText = "Aktif";
            this.toggleAktifmi.Size = new System.Drawing.Size(213, 18);
            this.toggleAktifmi.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 28);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Durumu :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(12, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 28);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Telefon :";
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(114, 111);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.textTelefon.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.textTelefon.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.textTelefon.Size = new System.Drawing.Size(213, 20);
            this.textTelefon.TabIndex = 14;
            // 
            // memoAdres
            // 
            this.memoAdres.Location = new System.Drawing.Point(114, 137);
            this.memoAdres.Name = "memoAdres";
            this.memoAdres.Size = new System.Drawing.Size(213, 60);
            this.memoAdres.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(12, 140);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 57);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Adres :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(12, 198);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 28);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "E-mail :";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(114, 203);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(213, 20);
            this.textEmail.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(12, 224);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 28);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Görevi :";
            // 
            // textGorevi
            // 
            this.textGorevi.Location = new System.Drawing.Point(114, 229);
            this.textGorevi.Name = "textGorevi";
            this.textGorevi.Size = new System.Drawing.Size(213, 20);
            this.textGorevi.TabIndex = 14;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(12, 250);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 28);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Kullanıcı Adı :";
            // 
            // textKullaniciAdi
            // 
            this.textKullaniciAdi.Location = new System.Drawing.Point(114, 255);
            this.textKullaniciAdi.Name = "textKullaniciAdi";
            this.textKullaniciAdi.Size = new System.Drawing.Size(213, 20);
            this.textKullaniciAdi.TabIndex = 14;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(12, 276);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(96, 28);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "Parola :";
            // 
            // textParola
            // 
            this.textParola.Location = new System.Drawing.Point(114, 281);
            this.textParola.Name = "textParola";
            this.textParola.Properties.UseSystemPasswordChar = true;
            this.textParola.Size = new System.Drawing.Size(213, 20);
            this.textParola.TabIndex = 14;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(12, 302);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(96, 28);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Parola Tekrar :";
            // 
            // textParolaTekrar
            // 
            this.textParolaTekrar.Location = new System.Drawing.Point(114, 307);
            this.textParolaTekrar.Name = "textParolaTekrar";
            this.textParolaTekrar.Properties.UseSystemPasswordChar = true;
            this.textParolaTekrar.Size = new System.Drawing.Size(213, 20);
            this.textParolaTekrar.TabIndex = 14;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Appearance.Options.UseBorderColor = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(12, 328);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(96, 28);
            this.labelControl11.TabIndex = 13;
            this.labelControl11.Text = "Parola Sorusu :";
            // 
            // textParolaSorusu
            // 
            this.textParolaSorusu.Location = new System.Drawing.Point(114, 333);
            this.textParolaSorusu.Name = "textParolaSorusu";
            this.textParolaSorusu.Size = new System.Drawing.Size(213, 20);
            this.textParolaSorusu.TabIndex = 14;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseBorderColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Location = new System.Drawing.Point(12, 354);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(96, 28);
            this.labelControl12.TabIndex = 13;
            this.labelControl12.Text = "Soru Cevabı :";
            // 
            // textCevap
            // 
            this.textCevap.Location = new System.Drawing.Point(114, 359);
            this.textCevap.Name = "textCevap";
            this.textCevap.Properties.UseSystemPasswordChar = true;
            this.textCevap.Size = new System.Drawing.Size(213, 20);
            this.textCevap.TabIndex = 14;
            // 
            // memoAciklama
            // 
            this.memoAciklama.Location = new System.Drawing.Point(114, 385);
            this.memoAciklama.Name = "memoAciklama";
            this.memoAciklama.Size = new System.Drawing.Size(213, 60);
            this.memoAciklama.TabIndex = 17;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseBorderColor = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Appearance.Options.UseTextOptions = true;
            this.labelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.Location = new System.Drawing.Point(30, 468);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(315, 16);
            this.labelControl14.TabIndex = 18;
            this.labelControl14.Text = "Samka Yazılım : www.samkasoft.com / +90 545 694 30 30 ";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl15.Appearance.Options.UseBorderColor = true;
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.Location = new System.Drawing.Point(12, 402);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(96, 28);
            this.labelControl15.TabIndex = 19;
            this.labelControl15.Text = "Açıklama :";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl13.Appearance.Options.UseBorderColor = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Location = new System.Drawing.Point(30, 451);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(315, 16);
            this.labelControl13.TabIndex = 13;
            this.labelControl13.Text = "LÜTFEN TÜM BİLGİLERİ GİRİNİZ.. ";
            // 
            // FrmKaydol
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 590);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.memoAciklama);
            this.Controls.Add(this.memoAdres);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.toggleAktifmi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.textCevap);
            this.Controls.Add(this.textParolaSorusu);
            this.Controls.Add(this.textParolaTekrar);
            this.Controls.Add(this.textParola);
            this.Controls.Add(this.textKullaniciAdi);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.textGorevi);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.textAdSoyad);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKaydol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samka Yazılım-Kullanıcı Kaydı";
            ((System.ComponentModel.ISupportInitialize)(this.textAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleAktifmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGorevi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParolaTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textParolaSorusu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.ToggleSwitch toggleAktifmi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textTelefon;
        private DevExpress.XtraEditors.MemoEdit memoAdres;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textGorevi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textParola;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textParolaTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textParolaSorusu;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit textCevap;
        private DevExpress.XtraEditors.MemoEdit memoAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}