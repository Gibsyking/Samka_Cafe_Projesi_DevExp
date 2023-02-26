using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SamkaCafe.Winforms.Kullanicilar;
using SamkaCafe.Winforms.Masalar;
using SamkaCafe.Winforms.Menuler;
using SamkaCafe.Winforms.Musteriler;
using SamkaCafe.Winforms.Urunler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamkaCafe.Winforms.AnaMenu
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void FrmGetir(XtraForm frm)
        {
            frm.MdiParent= this; // TEK SEFERDE TANIMLANAN DEĞER İLE DİĞER FORMLAR HEMEN ÇAĞRILIR.
            frm.Show();
        }
        public FrmAnaMenu()
        {
            // KULLANICI GİRİŞ ÖNCE BURAYA TANIMLANIR VE PROGRAM.CS GİRİŞ YERİ DEĞİŞTİRİLMEZ.
            InitializeComponent();
            XtraForm fr =new FrmKullaniciGirisi();
            fr.ShowDialog();
        }

     

        private void btnUrun_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmUrunler(); // TEK SEFERDE TANIMLANAN DEĞER İLE DİĞER FORMLAR HEMEN ÇAĞRILIR. VE MDİ PARANT İÇERİSİNDE GÖSTERİLİR.
            FrmGetir(frm);
        }

        private void btnMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmMenüler(); // SHOW DİYALOG YANİ EKSTRA BİR PENCERE AÇILIR ÇALIŞTIRILDIĞINDA..
            frm.ShowDialog();
        }

        private void btnmasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmMasaAyarlarİ(); // TEK SEFERDE TANIMLANAN DEĞER İLE DİĞER FORMLAR HEMEN ÇAĞRILIR. VE MDİ PARANT İÇERİSİNDE GÖSTERİLİR.
            FrmGetir(frm);
        }

        private void btnmasalarr_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm fr=new FrmMasaDurumlari();
            FrmGetir(fr);
        }

        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm fr = new FrmMusteriler();
            FrmGetir(fr);
        }
    }
}