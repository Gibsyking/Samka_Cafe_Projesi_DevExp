namespace SamkaCafe.Winforms.Masalar
{
    partial class FrmMasaDurumlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaDurumlari));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grouphesaplamalar = new DevExpress.XtraEditors.GroupControl();
            this.btnbtnyenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnsiparis = new DevExpress.XtraEditors.SimpleButton();
            this.btnmasaac = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnrezerve = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grouphesaplamalar)).BeginInit();
            this.grouphesaplamalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1183, 35);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Masa Kayıt";
            // 
            // grouphesaplamalar
            // 
            this.grouphesaplamalar.Controls.Add(this.btnbtnyenile);
            this.grouphesaplamalar.Controls.Add(this.btnsiparis);
            this.grouphesaplamalar.Controls.Add(this.btnrezerve);
            this.grouphesaplamalar.Controls.Add(this.btnmasaac);
            this.grouphesaplamalar.Controls.Add(this.btnkapat);
            this.grouphesaplamalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grouphesaplamalar.Location = new System.Drawing.Point(0, 422);
            this.grouphesaplamalar.Name = "grouphesaplamalar";
            this.grouphesaplamalar.Size = new System.Drawing.Size(1183, 106);
            this.grouphesaplamalar.TabIndex = 5;
            this.grouphesaplamalar.Text = "İŞLEMLER";
            // 
            // btnbtnyenile
            // 
            this.btnbtnyenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbtnyenile.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnbtnyenile.Appearance.Options.UseFont = true;
            this.btnbtnyenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRezervDegistir.ImageOptions.SvgImage")));
            this.btnbtnyenile.Location = new System.Drawing.Point(957, 28);
            this.btnbtnyenile.Name = "btnbtnyenile";
            this.btnbtnyenile.Size = new System.Drawing.Size(104, 66);
            this.btnbtnyenile.TabIndex = 6;
            this.btnbtnyenile.Text = "YENİLE";
            // 
            // btnsiparis
            // 
            this.btnsiparis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsiparis.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnsiparis.Appearance.Options.UseFont = true;
            this.btnsiparis.Enabled = false;
            this.btnsiparis.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnyenile.ImageOptions.SvgImage")));
            this.btnsiparis.Location = new System.Drawing.Point(737, 28);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(104, 66);
            this.btnsiparis.TabIndex = 5;
            this.btnsiparis.Text = "SİPARİŞ";
            // 
            // btnmasaac
            // 
            this.btnmasaac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmasaac.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnmasaac.Appearance.Options.UseFont = true;
            this.btnmasaac.Enabled = false;
            this.btnmasaac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnkaydet.ImageOptions.SvgImage")));
            this.btnmasaac.Location = new System.Drawing.Point(627, 28);
            this.btnmasaac.Name = "btnmasaac";
            this.btnmasaac.Size = new System.Drawing.Size(104, 66);
            this.btnmasaac.TabIndex = 0;
            this.btnmasaac.Text = "MASA AÇ";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnkapat.Appearance.Options.UseFont = true;
            this.btnkapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage1")));
            this.btnkapat.Location = new System.Drawing.Point(1067, 28);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(104, 66);
            this.btnkapat.TabIndex = 2;
            this.btnkapat.Text = "KAPAT";
            // 
            // btnrezerve
            // 
            this.btnrezerve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrezerve.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnrezerve.Appearance.Options.UseFont = true;
            this.btnrezerve.Enabled = false;
            this.btnrezerve.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnrezerve.Location = new System.Drawing.Point(847, 28);
            this.btnrezerve.Name = "btnrezerve";
            this.btnrezerve.Size = new System.Drawing.Size(104, 66);
            this.btnrezerve.TabIndex = 0;
            this.btnrezerve.Text = "REZERVE";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1183, 387);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // FrmMasaDurumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1183, 528);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grouphesaplamalar);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMasaDurumlari";
            this.Text = "Masalar";
            ((System.ComponentModel.ISupportInitialize)(this.grouphesaplamalar)).EndInit();
            this.grouphesaplamalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl grouphesaplamalar;
        private DevExpress.XtraEditors.SimpleButton btnbtnyenile;
        private DevExpress.XtraEditors.SimpleButton btnsiparis;
        private DevExpress.XtraEditors.SimpleButton btnrezerve;
        private DevExpress.XtraEditors.SimpleButton btnmasaac;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}