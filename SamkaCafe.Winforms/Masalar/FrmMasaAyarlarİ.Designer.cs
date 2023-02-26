namespace SamkaCafe.Winforms.Masalar
{
    partial class FrmMasaAyarlarİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaAyarlarİ));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRezervDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnDurumDeğiştir = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnDüzenle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRezerveMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEklenmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasaHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnRezervDegistir);
            this.groupControl1.Controls.Add(this.btnDurumDeğiştir);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnDüzenle);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnYeniKayıt);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 417);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1193, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İŞLEMLER";
            // 
            // btnRezervDegistir
            // 
            this.btnRezervDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezervDegistir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRezervDegistir.ImageOptions.SvgImage")));
            this.btnRezervDegistir.Location = new System.Drawing.Point(873, 42);
            this.btnRezervDegistir.Name = "btnRezervDegistir";
            this.btnRezervDegistir.Size = new System.Drawing.Size(107, 46);
            this.btnRezervDegistir.TabIndex = 6;
            this.btnRezervDegistir.Text = "REZERV\r\nDEĞİŞTİR";
            this.btnRezervDegistir.Click += new System.EventHandler(this.btnRezervDegistir_Click);
            // 
            // btnDurumDeğiştir
            // 
            this.btnDurumDeğiştir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDurumDeğiştir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDurumDeğiştir.ImageOptions.SvgImage")));
            this.btnDurumDeğiştir.Location = new System.Drawing.Point(769, 42);
            this.btnDurumDeğiştir.Name = "btnDurumDeğiştir";
            this.btnDurumDeğiştir.Size = new System.Drawing.Size(98, 46);
            this.btnDurumDeğiştir.TabIndex = 5;
            this.btnDurumDeğiştir.Text = "DURUM\r\nDEĞİŞTİR";
            this.btnDurumDeğiştir.Click += new System.EventHandler(this.btnDurumDeğiştir_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Location = new System.Drawing.Point(668, 42);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(95, 46);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDüzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDüzenle.ImageOptions.SvgImage")));
            this.btnDüzenle.Location = new System.Drawing.Point(568, 42);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(94, 46);
            this.btnDüzenle.TabIndex = 3;
            this.btnDüzenle.Text = "DÜZENLE";
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(1093, 42);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 46);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "KAPAT";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(986, 42);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 46);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "MASA SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeniKayıt
            // 
            this.btnYeniKayıt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeniKayıt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYeniKayıt.ImageOptions.SvgImage")));
            this.btnYeniKayıt.Location = new System.Drawing.Point(426, 42);
            this.btnYeniKayıt.Name = "btnYeniKayıt";
            this.btnYeniKayıt.Size = new System.Drawing.Size(136, 46);
            this.btnYeniKayıt.TabIndex = 0;
            this.btnYeniKayıt.Text = "YENİ MASA KAYIT";
            this.btnYeniKayıt.Click += new System.EventHandler(this.btnYeniKayıt_Click);
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
            this.labelControl1.Size = new System.Drawing.Size(1193, 35);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Masa Ayarları";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1193, 382);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMasaAdi,
            this.colAciklama,
            this.colDurumu,
            this.colRezerveMi,
            this.colEklenmeTarihi,
            this.colSonIslemTarihi,
            this.colIslem,
            this.colKullaniciId,
            this.colmasaHareketleri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 39;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa Adı";
            this.colMasaAdi.FieldName = "MasaAdi";
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 1;
            this.colMasaAdi.Width = 200;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 257;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 3;
            this.colDurumu.Width = 55;
            // 
            // colRezerveMi
            // 
            this.colRezerveMi.Caption = "Rezerve";
            this.colRezerveMi.FieldName = "RezerveMi";
            this.colRezerveMi.Name = "colRezerveMi";
            this.colRezerveMi.Visible = true;
            this.colRezerveMi.VisibleIndex = 4;
            this.colRezerveMi.Width = 55;
            // 
            // colEklenmeTarihi
            // 
            this.colEklenmeTarihi.FieldName = "EklenmeTarihi";
            this.colEklenmeTarihi.Name = "colEklenmeTarihi";
            this.colEklenmeTarihi.Visible = true;
            this.colEklenmeTarihi.VisibleIndex = 5;
            this.colEklenmeTarihi.Width = 80;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.Visible = true;
            this.colSonIslemTarihi.VisibleIndex = 6;
            this.colSonIslemTarihi.Width = 89;
            // 
            // colIslem
            // 
            this.colIslem.Caption = "İşlem";
            this.colIslem.FieldName = "Islem";
            this.colIslem.Name = "colIslem";
            this.colIslem.Visible = true;
            this.colIslem.VisibleIndex = 8;
            this.colIslem.Width = 187;
            // 
            // colKullaniciId
            // 
            this.colKullaniciId.Caption = "Kullanıcı Adı";
            this.colKullaniciId.FieldName = "Kullanici";
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.Visible = true;
            this.colKullaniciId.VisibleIndex = 7;
            this.colKullaniciId.Width = 206;
            // 
            // colmasaHareketleri
            // 
            this.colmasaHareketleri.FieldName = "masaHareketleri";
            this.colmasaHareketleri.Name = "colmasaHareketleri";
            // 
            // FrmMasaAyarlarİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 517);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMasaAyarlarİ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masalar Ayarları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDüzenle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeniKayıt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colRezerveMi;
        private DevExpress.XtraGrid.Columns.GridColumn colEklenmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
        private DevExpress.XtraGrid.Columns.GridColumn colmasaHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnRezervDegistir;
        private DevExpress.XtraEditors.SimpleButton btnDurumDeğiştir;
    }
}