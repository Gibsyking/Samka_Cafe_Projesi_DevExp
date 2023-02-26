using DevExpress.XtraEditors;
//using SamkaCafe.Winforms.WinTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamkaCafe.Entitiy.Models;
using System.Runtime.Remoting.Contexts;

namespace SamkaCafe.Winforms.Masalar
{
    public partial class FrmMasaDurumlari : DevExpress.XtraEditors.XtraForm
    {


        CafeContext context = new CafeContext();
        CheckButton btn;
        public FrmMasaDurumlari()
        {
            // DİNAMİK MASALARDA TANIMLANAN KATMANI ÇEKMEK İÇİN KULLANILAN METOT.
            InitializeComponent();
            MasalariGetir();
        }
        private Color FromRgbExample()
        {
            // Create a green color using the FromRgb static method.
            // RGB İLE RENK ÜRETMEK İÇİN KULLANULIR..
            Color myRgbColor = new Color();
            Color myRgbColor1 = new Color();
            Color myRgbColor2 = new Color();
            // myRgbColor = Color.FromArgb(192, 0, 0);
            myRgbColor1 = Color.FromArgb(192, 0, 0);
            myRgbColor2 = Color.FromArgb(44, 44, 84);


            // return myRgbColor;
            return myRgbColor1;
            return myRgbColor2;
        }
        public void MasalariGetir()
        {

            // MASALARI GETİRMEK VE İÇERİSİNDE LİSTELEMEK İÇİN KULLANILAN METOT.
            //floyut PANEL  İÇERİSİNE BUTTONLARI MASA TARZI EKLEME..
            var model = context.Masalar.ToList();

            for (int i = 0; i < model.Count; i++)
            {
                btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Name = model[i].Id.ToString();
                btn.Height = 100;
                btn.Width = 80;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
                /// DURUMA GÖRE MASA RENKLENDİRME

                if (model[i].RezerveMi && !model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Gold;

                }
                else if (!model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.FromArgb(44, 44, 84);
                }
                else if (model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.FromArgb(192, 0, 0);
                }


            }
        }

        // DURUMA GÖRE AÇIK KAPALI VEYA REZERV MASAYA TIKLAYINCA HANGİSİ AKTİF HANGİSİ PASİF OLSUN BOTUNLARININ ŞEÇENEĞİ.
        public void DurumlariYenile()
        {
            btnsiparis.Enabled = false; // BAŞLANGIÇTA KAPALI ÇALIŞACAK BUTTONLAR..
            btnmasaac.Enabled = false;
            btnrezerve.Enabled = false;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            CheckButton tiklananbtn = sender as CheckButton; // BOTUNLARA AKTİF PASİF REZERV GİBİ DURUMLARI KULLANILAN YÖNTEM..
            DurumlariYenile();
            if (tiklananbtn.Appearance.BackColor==Color.Gold) // DURUMA GÖRE TIKLANINCA AÇILACAK BUTTONLARIN ŞEÇİMİ..
            {
                btnmasaac.Enabled = true;
            }
            else if (tiklananbtn.Appearance.BackColor == Color.FromArgb(44, 44, 84))// DURUMA GÖRE TIKLANINCA AÇILACAK BUTTONLARIN ŞEÇİMİ..
            {
                btnmasaac.Enabled = true;
                btnrezerve.Enabled = true;
            }
            else if (tiklananbtn.Appearance.BackColor == Color.FromArgb(192, 0, 0))// DURUMA GÖRE TIKLANINCA AÇILACAK BUTTONLARIN ŞEÇİMİ..
            {
                btnsiparis.Enabled = true;
            }
        }
    }
}
