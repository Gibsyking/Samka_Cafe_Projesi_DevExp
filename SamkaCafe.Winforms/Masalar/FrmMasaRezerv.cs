using DevExpress.XtraEditors;
using SamkaCafe.Entitiy.DAL;
using SamkaCafe.Entitiy.Models;
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

namespace SamkaCafe.Winforms.Masalar
{
    public partial class FrmMasaRezerv : DevExpress.XtraEditors.XtraForm
    {
        int _masaId;
        public bool islemyapildi;
        Entitiy.Models.Masalar masalar;
        MasalarDAL masalarDAL = new MasalarDAL();
        CafeContext context=new CafeContext();
        public FrmMasaRezerv(int masaId)
        {
            InitializeComponent();
            _masaId = masaId;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            masalar = masalarDAL.GetbyFilter(context, m => m.Id == _masaId);
            masalar.Islem = memoEditislem.Text;
            masalar.SonIslemTarihi =Convert.ToDateTime( dateEdittarih.EditValue);
            masalar.KullaniciId = Kullaniciayarlari.kullaniciId;
            masalar.RezerveMi = true;
            masalarDAL.Save(context);
            islemyapildi= true; 
            this.Close();   

        }
    }
}