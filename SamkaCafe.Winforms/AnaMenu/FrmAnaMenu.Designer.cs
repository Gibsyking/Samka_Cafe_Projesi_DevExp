namespace SamkaCafe.Winforms.AnaMenu
{
    partial class FrmAnaMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnmasaayar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMasaHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenüHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrun = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanicilar = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoller = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnmasalarr = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnmasaayar,
            this.btnMasaHareketleri,
            this.btnMenu,
            this.btnMenüHareketleri,
            this.btnUrun,
            this.btnUrunHareketleri,
            this.btnKullanicilar,
            this.btnKullaniciHareketleri,
            this.btnRoller,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnmasalarr,
            this.btnMusteriler});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1265, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
//            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnmasaayar
            // 
            this.btnmasaayar.Caption = "MASA AYARLARI";
            this.btnmasaayar.Id = 1;
            this.btnmasaayar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnmasaayar.ImageOptions.SvgImage")));
            this.btnmasaayar.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmasaayar.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnmasaayar.Name = "btnmasaayar";
            this.btnmasaayar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmasalar_ItemClick);
            // 
            // btnMasaHareketleri
            // 
            this.btnMasaHareketleri.Caption = "MASA HAREKETLERİ";
            this.btnMasaHareketleri.Id = 2;
            this.btnMasaHareketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMasaHareketleri.ImageOptions.SvgImage")));
            this.btnMasaHareketleri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaHareketleri.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMasaHareketleri.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaHareketleri.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnMasaHareketleri.Name = "btnMasaHareketleri";
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "MENÜ";
            this.btnMenu.Id = 3;
            this.btnMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenu.ImageOptions.SvgImage")));
            this.btnMenu.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenu_ItemClick);
            // 
            // btnMenüHareketleri
            // 
            this.btnMenüHareketleri.Caption = "MENÜ HAREKETLERİ";
            this.btnMenüHareketleri.Id = 4;
            this.btnMenüHareketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenüHareketleri.ImageOptions.SvgImage")));
            this.btnMenüHareketleri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenüHareketleri.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMenüHareketleri.Name = "btnMenüHareketleri";
            // 
            // btnUrun
            // 
            this.btnUrun.Caption = "ÜRÜN";
            this.btnUrun.Id = 5;
            this.btnUrun.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrun.ImageOptions.SvgImage")));
            this.btnUrun.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrun.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrun_ItemClick);
            // 
            // btnUrunHareketleri
            // 
            this.btnUrunHareketleri.Caption = "ÜRÜN HAREKETLERİ";
            this.btnUrunHareketleri.Id = 6;
            this.btnUrunHareketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunHareketleri.ImageOptions.SvgImage")));
            this.btnUrunHareketleri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunHareketleri.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrunHareketleri.Name = "btnUrunHareketleri";
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Caption = "KULLANICILAR";
            this.btnKullanicilar.Id = 7;
            this.btnKullanicilar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKullanicilar.ImageOptions.SvgImage")));
            this.btnKullanicilar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanicilar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKullanicilar.Name = "btnKullanicilar";
            // 
            // btnKullaniciHareketleri
            // 
            this.btnKullaniciHareketleri.Caption = "KULLANICI HAREKETLERİ";
            this.btnKullaniciHareketleri.Id = 8;
            this.btnKullaniciHareketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKullaniciHareketleri.ImageOptions.SvgImage")));
            this.btnKullaniciHareketleri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciHareketleri.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKullaniciHareketleri.Name = "btnKullaniciHareketleri";
            // 
            // btnRoller
            // 
            this.btnRoller.Caption = "KULLANICI ROLLERİ";
            this.btnRoller.Id = 9;
            this.btnRoller.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRoller.ImageOptions.SvgImage")));
            this.btnRoller.Name = "btnRoller";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "DOVİZ İŞLEMLERİ";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "YARDIM";
            this.barButtonItem3.Id = 11;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "HAKKINDA";
            this.barButtonItem4.Id = 12;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnmasalarr
            // 
            this.btnmasalarr.Caption = "MASALAR";
            this.btnmasalarr.Id = 13;
            this.btnmasalarr.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnmasalarr.ImageOptions.SvgImage")));
            this.btnmasalarr.Name = "btnmasalarr";
            this.btnmasalarr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmasalarr_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnmasalarr);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnmasaayar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMasaHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Masa İşlemleri";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnMenu);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnMenüHareketleri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Menü İşlemleri";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup5.ImageOptions.SvgImage")));
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUrun);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUrunHareketleri);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Ürün İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKullanicilar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKullaniciHareketleri);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRoller);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Ayarlar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "İşlemler";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 533);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1265, 24);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "MASALAR";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem1.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Müşteri İşlemleri";
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "Müşteriler";
            this.btnMusteriler.Id = 14;
            this.btnMusteriler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.btnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 557);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmAnaMenu.IconOptions.SvgImage")));
            this.IsMdiContainer = true;
            this.Name = "FrmAnaMenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "SAMKA YAZILIM CAFE OTOMASYONU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnmasaayar;
        private DevExpress.XtraBars.BarButtonItem btnMasaHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnMenu;
        private DevExpress.XtraBars.BarButtonItem btnMenüHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnUrun;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnUrunHareketleri;
        private DevExpress.XtraBars.BarButtonItem btnKullanicilar;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnRoller;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnmasalarr;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}