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

namespace SamkaCafe.Winforms.Urunler
{
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        UrunDAL urunDAL = new UrunDAL();
       
        public FrmUrunler()
        {
            InitializeComponent();
            listele();
        }

        private void listele()
        {
            gridControl1.DataSource = urunDAL.Urunlistele(context);
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            FrmUrunKaydet frm = new FrmUrunKaydet(new Urun());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                listele();
            }
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {

        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {

            // ŞEÇİLİ ÜRÜNÜ DÜZENLEME İÇİN
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            FrmUrunKaydet frm = new FrmUrunKaydet(urunDAL.GetbyFilter(context, u => u.Id == seciliid));
            frm.ShowDialog();
            if (frm.kaydet)
            {
                listele();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listele(); // LİSTELE METODU
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            /// ŞEÇİLİ ÜRÜNLERİ SİLME İÇİN
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if(XtraMessageBox.Show("Şeçili Ürün Silinecek Onaylıyormusunuz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                urunDAL.Delete(context,u=>u.Id==seciliid);
                urunDAL.Save(context);
                listele();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}