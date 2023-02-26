using DevExpress.XtraEditors;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamkaCafe.Winforms.Musteriler
{
    public partial class FrmMusteriler : DevExpress.XtraEditors.XtraForm
    {

        CafeContext context=new CafeContext();
        public FrmMusteriler()
        {
            InitializeComponent();
            context.Musteriler.Load();
            gridControl1.DataSource = context.Musteriler.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Şeçili Müşteri Silinsin mi", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) ;
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}