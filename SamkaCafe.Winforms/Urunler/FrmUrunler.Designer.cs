namespace SamkaCafe.Winforms.Urunler
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnDüzenle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(1033, 35);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnDüzenle);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnYeniKayıt);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 435);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1033, 100);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İŞLEMLER";
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Location = new System.Drawing.Point(248, 42);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(108, 46);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDüzenle.ImageOptions.SvgImage")));
            this.btnDüzenle.Location = new System.Drawing.Point(134, 42);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(108, 46);
            this.btnDüzenle.TabIndex = 3;
            this.btnDüzenle.Text = "DÜZENLE";
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(933, 42);
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
            this.btnSil.Location = new System.Drawing.Point(840, 42);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 46);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeniKayıt
            // 
            this.btnYeniKayıt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYeniKayıt.ImageOptions.SvgImage")));
            this.btnYeniKayıt.Location = new System.Drawing.Point(20, 42);
            this.btnYeniKayıt.Name = "btnYeniKayıt";
            this.btnYeniKayıt.Size = new System.Drawing.Size(108, 46);
            this.btnYeniKayıt.TabIndex = 0;
            this.btnYeniKayıt.Text = "YENİ KAYIT";
            this.btnYeniKayıt.Click += new System.EventHandler(this.btnYeniKayıt_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1033, 400);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Gray;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMenuId,
            this.colUrunKodu,
            this.colUrunAdi,
            this.colBirimFiyati1,
            this.colBirimFiyati2,
            this.colBirimFiyati3,
            this.colAciklama,
            this.colTarih,
            this.colResim,
            this.colMenu,
            this.colMenuAdı});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBirimFiyati1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 26;
            // 
            // colMenuId
            // 
            this.colMenuId.FieldName = "MenuId";
            this.colMenuId.Name = "colMenuId";
            this.colMenuId.Width = 44;
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.Caption = "Ürün Kodu";
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 2;
            this.colUrunKodu.Width = 62;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 3;
            this.colUrunAdi.Width = 224;
            // 
            // colBirimFiyati1
            // 
            this.colBirimFiyati1.Caption = "Birim Fiyati 1";
            this.colBirimFiyati1.FieldName = "BirimFiyati1";
            this.colBirimFiyati1.Name = "colBirimFiyati1";
            this.colBirimFiyati1.Visible = true;
            this.colBirimFiyati1.VisibleIndex = 4;
            // 
            // colBirimFiyati2
            // 
            this.colBirimFiyati2.Caption = "Birim Fiyati 2";
            this.colBirimFiyati2.FieldName = "BirimFiyati2";
            this.colBirimFiyati2.Name = "colBirimFiyati2";
            this.colBirimFiyati2.Visible = true;
            this.colBirimFiyati2.VisibleIndex = 5;
            this.colBirimFiyati2.Width = 69;
            // 
            // colBirimFiyati3
            // 
            this.colBirimFiyati3.Caption = "Birim Fiyati 3";
            this.colBirimFiyati3.FieldName = "BirimFiyati3";
            this.colBirimFiyati3.Name = "colBirimFiyati3";
            this.colBirimFiyati3.Visible = true;
            this.colBirimFiyati3.VisibleIndex = 6;
            this.colBirimFiyati3.Width = 69;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 305;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 8;
            this.colTarih.Width = 86;
            // 
            // colResim
            // 
            this.colResim.Caption = "Resim";
            this.colResim.FieldName = "Resim";
            this.colResim.Name = "colResim";
            this.colResim.Width = 91;
            // 
            // colMenu
            // 
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            this.colMenu.Width = 82;
            // 
            // colMenuAdı
            // 
            this.colMenuAdı.Caption = "Menü Adı";
            this.colMenuAdı.FieldName = "Menu";
            this.colMenuAdı.Name = "colMenuAdı";
            this.colMenuAdı.Visible = true;
            this.colMenuAdı.VisibleIndex = 1;
            this.colMenuAdı.Width = 92;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 535);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDüzenle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeniKayıt;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colResim;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdı;
    }
}