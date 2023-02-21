using DevExpress.XtraEditors;
using SamkaCafe.Entitiy.DAL;
using SamkaCafe.Entitiy.Mapping;
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
    public partial class FrmKaydol : DevExpress.XtraEditors.XtraForm
    {

        CafeContext context = new CafeContext();
        KullanicilarDAL kullanicilarDAL = new KullanicilarDAL();
        Entitiy.Models.Kullanicilar _entity;

        public FrmKaydol(Entitiy.Models.Kullanicilar entity)
        {
            InitializeComponent();
            _entity = entity;
            //KULLANICI KAYDI
            toggleAktifmi.DataBindings.Add("EditValue", _entity, "AktifMi");
            textAdSoyad.DataBindings.Add("Text", _entity, "AdSoyad");
            textTelefon.DataBindings.Add("Text", _entity, "Telefon1");
            memoAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            textEmail.DataBindings.Add("Text", _entity, "Email");
            textGorevi.DataBindings.Add("Text", _entity, "Gorevı");
            textKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi");
            textParola.DataBindings.Add("Text", _entity, "Parola");
            textParolaSorusu.DataBindings.Add("Text", _entity, "HatirlatmaSorusu");
            textCevap.DataBindings.Add("Text", _entity, "Cevap");
            memoAdres.DataBindings.Add("Text", _entity, "Adres");


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SQL VERİLERİ GÖNDERMEK İÇİN ADDORUPDATE İLE YUKARIDA TANIMLANAN METOTLAR GÖNDERİLİR.
            _entity.KayitTarihi = DateTime.Now;
            if (textParola.Text == textParolaTekrar.Text)
            {
                if (kullanicilarDAL.AddOrUpdate(context, _entity))
                {
                    kullanicilarDAL.Save(context);

                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show("Parola Aynı Değil lütfen Tekrar Deneyiniz");
            }
        }
    }
}
