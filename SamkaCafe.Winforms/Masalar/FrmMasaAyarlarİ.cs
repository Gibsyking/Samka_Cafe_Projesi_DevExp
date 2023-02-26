using DevExpress.Utils.CodedUISupport;
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

namespace SamkaCafe.Winforms.Masalar
{
    public partial class FrmMasaAyarlarİ : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext(); //ENTİTİY BAĞLANTI KATMANI
        MasalarDAL masalarDAL = new MasalarDAL();    // BAĞLANILACAK TABLO VE YAPILACAK İŞLEM İÇİ ÇAĞRILAN METOT.



        public FrmMasaAyarlarİ()
        {
            InitializeComponent();
            listele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()  // BU ŞEKİLDE LİSTELİYEREK AYNI FORM İÇERİSİNDE KULLANLILABİLİR.
        {
            gridControl1.DataSource = masalarDAL.MasalariListele(context); // DATACONTROL İÇERİSİNDE KULLANILAN METOT. MASALARDAL İÇERİSİNDE MASALARI LİSTELE DEĞERİ İLE ÇAĞRILIR.
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            FrmMasaKaydet fr = new FrmMasaKaydet(new Entitiy.Models.Masalar());
            fr.ShowDialog();
            if (fr.kaydet)
            {
                listele();
            }
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            // MASALARI DÜZENLEME İÇİN KULLANILAN KOMUT.
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var masalar = masalarDAL.GetbyFilter(context, m => m.Id == seciliid);
            FrmMasaKaydet fr = new FrmMasaKaydet(masalar);
            fr.ShowDialog();
            if (fr.kaydet)
            {
                listele();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            /// ŞEÇİLİ MASA SİLME İÇİN KULLANILIR.
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (XtraMessageBox.Show("Şeçili Masa Silinecek Onaylıyormusunuz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                masalarDAL.Delete(context, m => m.Id == seciliid);
                masalarDAL.Save(context);
                listele();
            }
        }

        private void btnDurumDeğiştir_Click(object sender, EventArgs e)
        {
            // ŞEÇİLİ MASA DURUMUNU DEĞİŞTİRMEK İÇİN KULLANILIR.
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalarDAL.GetbyFilter(context, m => m.Id == seciliid);
                if (masalar.Durumu)
                {
                    masalar.Durumu = false;
                }
                else if (!masalar.Durumu)
                {
                    masalar.Durumu = true;
                }
                masalarDAL.Save(context);
                listele();
            }

        }

        private void btnRezervDegistir_Click(object sender, EventArgs e)
        {
            // ŞEÇİLİ MASA REZERV DURUMU DEĞİŞTİRMEK İÇİN KULLANILIR. 
            // TEKRAR BURASI HAKKINDA İNCELEME YAPILACAK.
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalarDAL.GetbyFilter(context, m => m.Id == seciliid);
                if (masalar.RezerveMi)
                {
                    masalar.RezerveMi = false;
                }
                else if (!masalar.RezerveMi)
                {
                    masalar.RezerveMi = true;
                }
                masalarDAL.Save(context);
                listele();
            }
        }

       
    }
}