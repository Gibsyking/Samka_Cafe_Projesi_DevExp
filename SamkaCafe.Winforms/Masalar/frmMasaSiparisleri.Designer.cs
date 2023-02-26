namespace SamkaCafe.Winforms.Masalar
{
    partial class frmMasaSiparisleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaSiparisleri));
            this.grouphesaplamalar = new DevExpress.XtraEditors.GroupControl();
            this.calcToplam = new DevExpress.XtraEditors.CalcEdit();
            this.calcindirimorani = new DevExpress.XtraEditors.CalcEdit();
            this.calcKalan = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.calcTutar = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.calcindirimtoplami = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.calcOdenen = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRezervDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnyenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grouphesaplamalar)).BeginInit();
            this.grouphesaplamalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcindirimorani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcKalan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcindirimtoplami.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcOdenen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grouphesaplamalar
            // 
            this.grouphesaplamalar.Controls.Add(this.calcToplam);
            this.grouphesaplamalar.Controls.Add(this.calcindirimorani);
            this.grouphesaplamalar.Controls.Add(this.calcKalan);
            this.grouphesaplamalar.Controls.Add(this.labelControl6);
            this.grouphesaplamalar.Controls.Add(this.labelControl4);
            this.grouphesaplamalar.Controls.Add(this.labelControl2);
            this.grouphesaplamalar.Controls.Add(this.calcTutar);
            this.grouphesaplamalar.Controls.Add(this.labelControl5);
            this.grouphesaplamalar.Controls.Add(this.calcindirimtoplami);
            this.grouphesaplamalar.Controls.Add(this.labelControl3);
            this.grouphesaplamalar.Controls.Add(this.calcOdenen);
            this.grouphesaplamalar.Controls.Add(this.labelControl1);
            this.grouphesaplamalar.Controls.Add(this.btnRezervDegistir);
            this.grouphesaplamalar.Controls.Add(this.btnyenile);
            this.grouphesaplamalar.Controls.Add(this.btnkaydet);
            this.grouphesaplamalar.Controls.Add(this.simpleButton1);
            this.grouphesaplamalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grouphesaplamalar.Location = new System.Drawing.Point(0, 370);
            this.grouphesaplamalar.Name = "grouphesaplamalar";
            this.grouphesaplamalar.Size = new System.Drawing.Size(1195, 151);
            this.grouphesaplamalar.TabIndex = 1;
            this.grouphesaplamalar.Text = "İŞLEMLER";
            // 
            // calcToplam
            // 
            this.calcToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calcToplam.Location = new System.Drawing.Point(655, 68);
            this.calcToplam.Name = "calcToplam";
            this.calcToplam.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.calcToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.calcToplam.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcToplam.Properties.Appearance.Options.UseBackColor = true;
            this.calcToplam.Properties.Appearance.Options.UseFont = true;
            this.calcToplam.Properties.Appearance.Options.UseForeColor = true;
            this.calcToplam.Properties.Appearance.Options.UseTextOptions = true;
            this.calcToplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcToplam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcToplam.Properties.MaskSettings.Set("mask", "c2");
            this.calcToplam.Properties.NullText = "₺ 0,00";
            this.calcToplam.Properties.UseMaskAsDisplayFormat = true;
            this.calcToplam.Size = new System.Drawing.Size(129, 26);
            this.calcToplam.TabIndex = 10;
            // 
            // calcindirimorani
            // 
            this.calcindirimorani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calcindirimorani.Location = new System.Drawing.Point(418, 68);
            this.calcindirimorani.Name = "calcindirimorani";
            this.calcindirimorani.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.calcindirimorani.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.calcindirimorani.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcindirimorani.Properties.Appearance.Options.UseBackColor = true;
            this.calcindirimorani.Properties.Appearance.Options.UseFont = true;
            this.calcindirimorani.Properties.Appearance.Options.UseForeColor = true;
            this.calcindirimorani.Properties.Appearance.Options.UseTextOptions = true;
            this.calcindirimorani.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcindirimorani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcindirimorani.Properties.MaskSettings.Set("mask", "P");
            this.calcindirimorani.Properties.NullText = "% 0,00";
            this.calcindirimorani.Properties.UseMaskAsDisplayFormat = true;
            this.calcindirimorani.Size = new System.Drawing.Size(150, 26);
            this.calcindirimorani.TabIndex = 10;
            // 
            // calcKalan
            // 
            this.calcKalan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calcKalan.Location = new System.Drawing.Point(134, 68);
            this.calcKalan.Name = "calcKalan";
            this.calcKalan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.calcKalan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.calcKalan.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcKalan.Properties.Appearance.Options.UseBackColor = true;
            this.calcKalan.Properties.Appearance.Options.UseFont = true;
            this.calcKalan.Properties.Appearance.Options.UseForeColor = true;
            this.calcKalan.Properties.Appearance.Options.UseTextOptions = true;
            this.calcKalan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcKalan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcKalan.Properties.MaskSettings.Set("mask", "c2");
            this.calcKalan.Properties.NullText = "₺ 0,00";
            this.calcKalan.Properties.UseMaskAsDisplayFormat = true;
            this.calcKalan.Size = new System.Drawing.Size(129, 26);
            this.calcKalan.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.AppearancePressed.Options.UseFont = true;
            this.labelControl6.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl6.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(557, 70);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 18);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Toplam :";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.AppearancePressed.Options.UseFont = true;
            this.labelControl4.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl4.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(276, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(133, 18);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "İndirim Oranı % :";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.AppearancePressed.Options.UseFont = true;
            this.labelControl2.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl2.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(36, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 18);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Kalan :";
            // 
            // calcTutar
            // 
            this.calcTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calcTutar.Location = new System.Drawing.Point(655, 28);
            this.calcTutar.Name = "calcTutar";
            this.calcTutar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.calcTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.calcTutar.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcTutar.Properties.Appearance.Options.UseBackColor = true;
            this.calcTutar.Properties.Appearance.Options.UseFont = true;
            this.calcTutar.Properties.Appearance.Options.UseForeColor = true;
            this.calcTutar.Properties.Appearance.Options.UseTextOptions = true;
            this.calcTutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcTutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcTutar.Properties.MaskSettings.Set("mask", "c2");
            this.calcTutar.Properties.NullText = "₺ 0,00";
            this.calcTutar.Properties.UseMaskAsDisplayFormat = true;
            this.calcTutar.Size = new System.Drawing.Size(129, 26);
            this.calcTutar.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.AppearancePressed.Options.UseFont = true;
            this.labelControl5.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl5.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(593, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 18);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Tutar :";
            // 
            // calcindirimtoplami
            // 
            this.calcindirimtoplami.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calcindirimtoplami.Location = new System.Drawing.Point(418, 28);
            this.calcindirimtoplami.Name = "calcindirimtoplami";
            this.calcindirimtoplami.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.calcindirimtoplami.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.calcindirimtoplami.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcindirimtoplami.Properties.Appearance.Options.UseBackColor = true;
            this.calcindirimtoplami.Properties.Appearance.Options.UseFont = true;
            this.calcindirimtoplami.Properties.Appearance.Options.UseForeColor = true;
            this.calcindirimtoplami.Properties.Appearance.Options.UseTextOptions = true;
            this.calcindirimtoplami.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcindirimtoplami.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcindirimtoplami.Properties.MaskSettings.Set("mask", "c2");
            this.calcindirimtoplami.Properties.NullText = "₺ 0,00";
            this.calcindirimtoplami.Properties.UseMaskAsDisplayFormat = true;
            this.calcindirimtoplami.Size = new System.Drawing.Size(150, 26);
            this.calcindirimtoplami.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.AppearancePressed.Options.UseFont = true;
            this.labelControl3.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl3.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(276, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "İndirim Toplamı :";
            // 
            // calcOdenen
            // 
            this.calcOdenen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calcOdenen.Location = new System.Drawing.Point(134, 28);
            this.calcOdenen.Name = "calcOdenen";
            this.calcOdenen.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.calcOdenen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.calcOdenen.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcOdenen.Properties.Appearance.Options.UseBackColor = true;
            this.calcOdenen.Properties.Appearance.Options.UseFont = true;
            this.calcOdenen.Properties.Appearance.Options.UseForeColor = true;
            this.calcOdenen.Properties.Appearance.Options.UseTextOptions = true;
            this.calcOdenen.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcOdenen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcOdenen.Properties.MaskSettings.Set("mask", "c2");
            this.calcOdenen.Properties.NullText = "₺ 0,00";
            this.calcOdenen.Properties.UseMaskAsDisplayFormat = true;
            this.calcOdenen.Size = new System.Drawing.Size(129, 26);
            this.calcOdenen.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl1.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(36, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 18);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Ödenen :";
            // 
            // btnRezervDegistir
            // 
            this.btnRezervDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezervDegistir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRezervDegistir.ImageOptions.SvgImage")));
            this.btnRezervDegistir.Location = new System.Drawing.Point(902, 31);
            this.btnRezervDegistir.Name = "btnRezervDegistir";
            this.btnRezervDegistir.Size = new System.Drawing.Size(86, 46);
            this.btnRezervDegistir.TabIndex = 6;
            this.btnRezervDegistir.Text = "YENİLE";
            // 
            // btnyenile
            // 
            this.btnyenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnyenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnyenile.ImageOptions.SvgImage")));
            this.btnyenile.Location = new System.Drawing.Point(802, 31);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(94, 46);
            this.btnyenile.TabIndex = 5;
            this.btnyenile.Text = "SİPARİŞ\r\nEKLE";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnkaydet.ImageOptions.SvgImage")));
            this.btnkaydet.Location = new System.Drawing.Point(994, 31);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(96, 46);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "KAYDET";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(1096, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 46);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "KAPAT";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl7.Location = new System.Drawing.Point(0, 0);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(1195, 35);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Masa";
            // 
            // frmMasaSiparisleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 521);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.grouphesaplamalar);
            this.Name = "frmMasaSiparisleri";
            this.Text = "frmMasaSiparisleri";
            ((System.ComponentModel.ISupportInitialize)(this.grouphesaplamalar)).EndInit();
            this.grouphesaplamalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calcToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcindirimorani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcKalan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcindirimtoplami.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcOdenen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grouphesaplamalar;
        private DevExpress.XtraEditors.CalcEdit calcToplam;
        private DevExpress.XtraEditors.CalcEdit calcindirimorani;
        private DevExpress.XtraEditors.CalcEdit calcKalan;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit calcTutar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CalcEdit calcindirimtoplami;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit calcOdenen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRezervDegistir;
        private DevExpress.XtraEditors.SimpleButton btnyenile;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}