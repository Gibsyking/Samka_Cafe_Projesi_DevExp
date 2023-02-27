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
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        MusterilerDAL musterilerDAL=new MusterilerDAL();
        int? _masaId= null;
        public frmMasaSiparisleri(int?masaId=null,string masaAdi=null,string satiskodu=null)
        {
            InitializeComponent();
            //MASA ADINI SİPARİS BASLIGINA TAŞIMA VE LOOKUPEDIT ICINDE MUSTERI GOSTERME
            _masaId=masaId;
            lookUpEditmusteri.Properties.DataSource = musterilerDAL.GetAll(context);
            if (_masaId!=null)
            {
                lblBaslik.Text = masaAdi + "   Siparisleri";
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            lookUpEditmusteri.EditValue = null;
        }

        private void repositoryItemSiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void repositoryItemodemesil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}