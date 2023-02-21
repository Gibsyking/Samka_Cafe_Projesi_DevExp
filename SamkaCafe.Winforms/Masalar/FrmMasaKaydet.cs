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

namespace SamkaCafe.Winforms.Masalar
{
    public partial class FrmMasaKaydet : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        MasalarDAL masalarDAL = new MasalarDAL();
        Entitiy.Models.Masalar _entity;
        public bool kaydet = false;
        public FrmMasaKaydet(Entitiy.Models.Masalar entity)
        {
            // MASA KAYDI İÇİN KULLANILAN YÖNTEM VE VERİTABANI İLE FİELDNAME LER AYNI OLMALIDIR..
            InitializeComponent();
            _entity = entity;
            textMasaAdı.DataBindings.Add("Text", _entity, "MasaAdi");
            memoAçıklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SQL DE NULL GEÇİLEMEZ DEĞERLERİ DEVRE DIŞI BIRAKMAK İÇİN KULLANILAN YÖNTEM 
            if (_entity.Id == 0)
            {
                _entity.Durumu = false;
                _entity.RezerveMi = false;
                _entity.EklenmeTarihi = DateTime.Now;
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Yeni Masa Ekledi.";
            }
            // MASA GÜNCELLENMESİ İÇİN KULLANILAN YÖNTEM
            else if (_entity.Id != 0)
            {
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Güncellendi.";
            }
            // MASA KAYDI İÇİN KULLANILAN YÖNTEM.

            if (masalarDAL.AddOrUpdate(context, _entity))
            {
                masalarDAL.Save(context);
                kaydet = true;


            }
            XtraMessageBox.Show("Masa Eklendi");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}