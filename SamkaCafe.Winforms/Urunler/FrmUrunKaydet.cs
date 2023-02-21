using DevExpress.XtraEditors;
using SamkaCafe.Entitiy.DAL;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamkaCafe.Winforms.Urunler
{
    public partial class FrmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        MenuDAL menuDAL = new MenuDAL();
        UrunDAL urunDAL = new UrunDAL();
        Urun _entity;
        CafeContext context = new CafeContext();
        public bool kaydet = false;
        public FrmUrunKaydet(Urun entity)
        {
            InitializeComponent();
            
            _entity = entity;
            ////// ÜRÜN KAYDI İÇİN
            lookUpMenüŞeçimi.Properties.DataSource = menuDAL.GetAll(context); // LookupEdit İÇERİSİNE VERİ ÇEKME
            lookUpMenüŞeçimi.DataBindings.Add("EditValue", _entity, "MenuId");
            textÜrünAdı.DataBindings.Add("Text", _entity, "UrunAdi");
            textÜrünKodu.DataBindings.Add("Text", _entity, "UrunKodu");
            calcBirimFiyat1.DataBindings.Add("Text", _entity, "BirimFiyati1", true);
            calcBirimFiyat2.DataBindings.Add("Text", _entity, "BirimFiyati2", true);
            calcBirimFiyat3.DataBindings.Add("Text", _entity, "BirimFiyati3", true);
            memoAçıklama.DataBindings.Add("Text", _entity, "Aciklama");
            dateEditTarih.DataBindings.Add("Text", _entity, "Tarih",true);              // ÜRÜN KAYDETME İÇİN KULLANLILAN KATMAN
            /////////// RESİM KAYDI İÇİN
            if (_entity.Id != 0) // RESİM GÖSTERME YOLU
            {
                if (_entity.Resim != null)
                {
                    pictureEditResimYükle.Image =Image.FromFile( _entity.Resim);
                }
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ////////// RESİM KAYDI
            if (pictureEditResimYükle.GetLoadedImageLocation()!="") // RESİM GÖSTERME YOLU
            {
                
                string hedefyol = $"{Application.StartupPath}\\Image\\{textÜrünAdı.Text}-{textÜrünKodu.Text}.png"; // RESİM YÜKLEME AYARLARI
                File.Copy(pictureEditResimYükle.GetLoadedImageLocation(), hedefyol);
                _entity.Resim = $"Image\\{textÜrünAdı.Text}-{textÜrünKodu.Text}.png";
            }
            /////////////////////ÜRÜN KAYDI
            if (urunDAL.AddOrUpdate(context, _entity))
            {
                urunDAL.Save(context); // GİRİLEN VERİLERİ BUTTON İLE GÖNDERME VE KAYDETME
                kaydet = true;
            }
            XtraMessageBox.Show("Kayıt Başarılı");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}