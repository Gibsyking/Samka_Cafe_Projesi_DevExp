using DevExpress.XtraEditors;
using SamkaCafe.Entitiy.DAL;
using SamkaCafe.Entitiy.Models;
using SamkaCafe.Winforms.AnaMenu;
using SamkaCafe.Winforms.WinTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamkaCafe.Winforms.Kullanicilar
{
    public partial class FrmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        bool giris;

        CafeContext context = new CafeContext();
        KullaniciHareketleriDAL kullaniciHareketleriDAL = new KullaniciHareketleriDAL();
        KullaniciHareketleri entity = new KullaniciHareketleri();

        // BENİ HATIRLA TRUE OLDUĞUNDA BİLGİLERİ KAYDET..
        void bilgikaydet()
        {
            if (checkBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = textKullaniciAdi.Text;
                Properties.Settings.Default.Parola = textSifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }


        }

        // BENİ HATIRLA ŞEÇENEĞİ TRUE OLDUĞUNDA KAYDEDİLMESİ İÇİN PROPERTİSE 
        void BilgiGetir()
        {
            if (Properties.Settings.Default.BeniHatirla == true)
            {
                textKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                textSifre.Text = Properties.Settings.Default.Parola;
                checkBeniHatirla.Checked = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                textKullaniciAdi.Text = null;
                textSifre.Text = null;
                checkBeniHatirla.Checked = false;

            }
        }




        //CONSTRAKTIR İÇERİSİNE BENİ HATIRLA METODU EKLENİR.
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
            BilgiGetir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == textKullaniciAdi.Text && k.Parola == textSifre.Text); // SQLDEN GELEN BİLGİLER DOĞRU İSE GİRİŞ YAP
            if (model != null)
            {
                giris = true;
                bilgikaydet();
                Kullaniciayarlari.kullaniciId = model.Id;

                entity.KullaniciId = model.Id; //
                string aciklama = model.KullaniciAdi + " Kullanıcı ismi ile sisteme giriş yapıldı";//

                kullaniciHareketleriDAL.KullaniciHareketleriEKLE(context, entity, aciklama); // KULLAICI HAREKETLERİNİ EKLER SİSTEME KİMİN NE ZAMAN GİRİŞ YAPTIĞI GÖRÜNÜLÜR.
                this.Close();
            }



            else
            {
                XtraMessageBox.Show("Kullanıcı Adı ve ya Şifre yanlış");
            }


        }
        // YENİ MÜŞTERİ KAYDI OLUŞTURUR
        private void hyperKaydol_Click(object sender, EventArgs e)
        {
            FrmKaydol fr = new FrmKaydol(new Entitiy.Models.Kullanicilar());
            fr.ShowDialog();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmParolamiUnuttum fr = new FrmParolamiUnuttum();
            fr.ShowDialog();
        }
    }
}