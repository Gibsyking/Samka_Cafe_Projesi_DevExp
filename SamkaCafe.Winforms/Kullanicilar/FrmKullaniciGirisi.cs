using DevExpress.XtraEditors;
using SamkaCafe.Entitiy.Models;
using SamkaCafe.Winforms.AnaMenu;
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
                Properties.Settings.Default.KullaniciAdi =null;
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
                textKullaniciAdi.Text=Properties.Settings.Default.KullaniciAdi;
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
            //EĞER SQL BİLGİLER VARSA GİRİŞ YAP 
            if (context.Kullanicilar.Any(k => k.KullaniciAdi == textKullaniciAdi.Text && k.Parola == textSifre.Text))
            {
                giris = true;
                bilgikaydet();
                this.Close();


            }



            else
            {
                XtraMessageBox.Show("Kullanıcı Adı ve ya Şifre yanlış");
            }


        }
        // YENİ MÜŞTERİ KAYDI
        private void hyperKaydol_Click(object sender, EventArgs e)
        {
            FrmKaydol fr=new FrmKaydol(new Entitiy.Models.Kullanicilar());
            fr.ShowDialog();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmParolamiUnuttum fr = new FrmParolamiUnuttum();
            fr.ShowDialog();
        }
    }
}