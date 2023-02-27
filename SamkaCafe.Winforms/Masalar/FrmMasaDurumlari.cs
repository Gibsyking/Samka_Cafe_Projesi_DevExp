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
using SamkaCafe.Entitiy.DAL;

namespace SamkaCafe.Winforms.Masalar
{
    public partial class FrmMasaDurumlari : DevExpress.XtraEditors.XtraForm
    {


        CafeContext context = new CafeContext();
        CheckButton btnsender;
        SatisKodu ModelSatiskodu;
        string _satiskodu;
        int _masaId;
        Entitiy.Models.Masalar masalar;
        MasalarDAL masalarDAL = new MasalarDAL();
        public FrmMasaDurumlari()
        {
            // DİNAMİK MASALARDA TANIMLANAN KATMANI ÇEKMEK İÇİN KULLANILAN METOT.
            InitializeComponent();
            ModelSatiskodu = context.SatisKodu.First();
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
            flowLayoutPanel1.Controls.Clear();
            context=new CafeContext();
            // MASALARI GETİRMEK VE İÇERİSİNDE LİSTELEMEK İÇİN KULLANILAN METOT.
            //floyut PANEL  İÇERİSİNE BUTTONLARI MASA TARZI EKLEME..
            var model = context.Masalar.ToList();

            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Name = model[i].Id.ToString();
                btn.Tag = model[i].SatisKodu;
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
            btnsender = sender as CheckButton; // BOTUNLARA AKTİF PASİF REZERV GİBİ DURUMLARI KULLANILAN YÖNTEM..
            _masaId = Convert.ToInt32(btnsender.Name);//MASA İSMİNİ GÖNDERME

            DurumlariYenile();
            if (btnsender.Appearance.BackColor == Color.Gold) // DURUMA GÖRE TIKLANINCA AÇILACAK BUTTONLARIN ŞEÇİMİ..
            {
                btnmasaac.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.FromArgb(44, 44, 84))// DURUMA GÖRE TIKLANINCA AÇILACAK BUTTONLARIN ŞEÇİMİ..
            {
                btnmasaac.Enabled = true;
                btnrezerve.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.FromArgb(192, 0, 0))// DURUMA GÖRE TIKLANINCA AÇILACAK BUTTONLARIN ŞEÇİMİ..
            {
                btnsiparis.Enabled = true;
            }
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            _satiskodu = btnsender.Tag.ToString();
            frmMasaSiparisleri fr = new frmMasaSiparisleri(_masaId, btnsender.Text);
            fr.Show();
        }

        private void btnmasaac_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(btnsender.Text + " Açılsın mı ? ", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                masalar = masalarDAL.GetbyFilter(context, m => m.Id == _masaId);
                masalar.SatisKodu = ModelSatiskodu.SatisTanimi + "-" + ModelSatiskodu.Sayi;
                masalar.Durumu = true;
                ModelSatiskodu.Sayi++;
                masalarDAL.Save(context);
                btnsender = null;
                DurumlariYenile();
                MasalariGetir();
            }
        }

        private void btnrezerve_Click(object sender, EventArgs e)
        {
            FrmMasaRezerv fr = new FrmMasaRezerv(_masaId);
            fr.ShowDialog();
            DurumlariYenile();
            if (fr.islemyapildi)
            {

                MasalariGetir();

            }
            btnsender = null;
        }
    }
}
