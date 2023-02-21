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

namespace SamkaCafe.Winforms.Menuler
{
    public partial class FrmMenüler : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        public FrmMenüler()
        {
            InitializeComponent();
            context.Menu.Load();
            gridControl1.DataSource = context.Menu.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
            XtraMessageBox.Show("Menü Kaydı Yapıldı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Şeçili Menü Silinsin mi", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) ;
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