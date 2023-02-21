using DevExpress.XtraEditors;
using SamkaCafe.Entitiy.DAL;
using SamkaCafe.Entitiy.Models;
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
    public partial class FrmParolamiUnuttum : DevExpress.XtraEditors.XtraForm
    {

        CafeContext context=new CafeContext();
        KullanicilarDAL kullanicilarDAL= new KullanicilarDAL();

        public FrmParolamiUnuttum()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // PAROLA DEĞİŞTİRME VE GİRİLEN ŞİFREYİ İSTENİLEN DEĞERLER İLE DOĞRULAMA
            var entitiy = kullanicilarDAL.GetbyFilter(context, k => k.KullaniciAdi == textKullaniciveyaeposta.Text || k.Email == textKullaniciveyaeposta.Text);
            if(entitiy != null )
            {
                if(entitiy.HatirlatmaSorusu==textSoru.Text && entitiy.Cevap == textCevap.Text)
                {
                    
                    if (textYeniParola.Text == textYeniParolaTekrar.Text)
                    {
                        entitiy.Parola = textYeniParola.Text;
                        if (kullanicilarDAL.AddOrUpdate(context, entitiy))
                        {
                            kullanicilarDAL.Save(context);
                            this.Close();
                            XtraMessageBox.Show("Parola Başarı ile değişti");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Parolalar Aynı değil Lütfen Tekrar Giriniz");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Hatirlatma Sorusu ve ya Cevabı Yanlış");
                }
            }
            else
            {
                XtraMessageBox.Show("Böyle bir Kullanıcı Bulunamadı");
            }
        }
    }
}