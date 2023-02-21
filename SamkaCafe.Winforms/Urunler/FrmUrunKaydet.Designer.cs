namespace SamkaCafe.Winforms.Urunler
{
    partial class FrmUrunKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunKaydet));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMenüŞeçimi = new DevExpress.XtraEditors.LookUpEdit();
            this.calcBirimFiyat1 = new DevExpress.XtraEditors.CalcEdit();
            this.calcBirimFiyat2 = new DevExpress.XtraEditors.CalcEdit();
            this.calcBirimFiyat3 = new DevExpress.XtraEditors.CalcEdit();
            this.memoAçıklama = new DevExpress.XtraEditors.MemoEdit();
            this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
            this.pictureEditResimYükle = new DevExpress.XtraEditors.PictureEdit();
            this.textÜrünKodu = new DevExpress.XtraEditors.TextEdit();
            this.textÜrünAdı = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenüŞeçimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyat1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyat2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyat3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAçıklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditResimYükle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textÜrünKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textÜrünAdı.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(471, 35);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün Kayıt";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 402);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(471, 100);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İŞLEMLER";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(371, 42);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 46);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(12, 42);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(108, 46);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(32, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 28);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Menü :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(33, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 28);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ürün Kodu :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(33, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 28);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Ürün Adı :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(33, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 28);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Birim Fiyatı 1 :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(33, 189);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 28);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Birim Fiyatı 2 :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(33, 223);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 28);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Birim Fiyatı 3 :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(33, 275);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 84);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Açıklama :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(33, 365);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(96, 28);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Tarih :";
            // 
            // lookUpMenüŞeçimi
            // 
            this.lookUpMenüŞeçimi.Location = new System.Drawing.Point(134, 57);
            this.lookUpMenüŞeçimi.Name = "lookUpMenüŞeçimi";
            this.lookUpMenüŞeçimi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMenüŞeçimi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuAdi", "Menü Adı"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aciklama", "Açıklama")});
            this.lookUpMenüŞeçimi.Properties.DisplayMember = "MenuAdi";
            this.lookUpMenüŞeçimi.Properties.NullText = "Menü Şeçimi";
            this.lookUpMenüŞeçimi.Properties.NullValuePrompt = "Menü Şeçimi";
            this.lookUpMenüŞeçimi.Properties.ValueMember = "Id";
            this.lookUpMenüŞeçimi.Size = new System.Drawing.Size(169, 20);
            this.lookUpMenüŞeçimi.TabIndex = 5;
            // 
            // calcBirimFiyat1
            // 
            this.calcBirimFiyat1.Location = new System.Drawing.Point(134, 159);
            this.calcBirimFiyat1.Name = "calcBirimFiyat1";
            this.calcBirimFiyat1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcBirimFiyat1.Properties.Appearance.Options.UseFont = true;
            this.calcBirimFiyat1.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyat1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyat1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyat1.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyat1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyat1.Properties.NullText = "0,00";
            this.calcBirimFiyat1.Size = new System.Drawing.Size(169, 22);
            this.calcBirimFiyat1.TabIndex = 8;
            // 
            // calcBirimFiyat2
            // 
            this.calcBirimFiyat2.Location = new System.Drawing.Point(134, 191);
            this.calcBirimFiyat2.Name = "calcBirimFiyat2";
            this.calcBirimFiyat2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcBirimFiyat2.Properties.Appearance.Options.UseFont = true;
            this.calcBirimFiyat2.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyat2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyat2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyat2.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyat2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyat2.Properties.NullText = "0,00";
            this.calcBirimFiyat2.Size = new System.Drawing.Size(169, 22);
            this.calcBirimFiyat2.TabIndex = 8;
            // 
            // calcBirimFiyat3
            // 
            this.calcBirimFiyat3.Location = new System.Drawing.Point(134, 228);
            this.calcBirimFiyat3.Name = "calcBirimFiyat3";
            this.calcBirimFiyat3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcBirimFiyat3.Properties.Appearance.Options.UseFont = true;
            this.calcBirimFiyat3.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyat3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyat3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyat3.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyat3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyat3.Properties.NullText = "0,00";
            this.calcBirimFiyat3.Size = new System.Drawing.Size(169, 22);
            this.calcBirimFiyat3.TabIndex = 8;
            // 
            // memoAçıklama
            // 
            this.memoAçıklama.Location = new System.Drawing.Point(134, 274);
            this.memoAçıklama.Name = "memoAçıklama";
            this.memoAçıklama.Properties.NullText = "Açıklama Yazınız";
            this.memoAçıklama.Size = new System.Drawing.Size(327, 85);
            this.memoAçıklama.TabIndex = 9;
            // 
            // dateEditTarih
            // 
            this.dateEditTarih.EditValue = null;
            this.dateEditTarih.Location = new System.Drawing.Point(135, 370);
            this.dateEditTarih.Name = "dateEditTarih";
            this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Size = new System.Drawing.Size(168, 20);
            this.dateEditTarih.TabIndex = 10;
            // 
            // pictureEditResimYükle
            // 
            this.pictureEditResimYükle.Location = new System.Drawing.Point(309, 57);
            this.pictureEditResimYükle.Name = "pictureEditResimYükle";
            this.pictureEditResimYükle.Properties.NullText = "Resim Yükleyin";
            this.pictureEditResimYükle.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditResimYükle.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditResimYükle.Size = new System.Drawing.Size(153, 193);
            this.pictureEditResimYükle.TabIndex = 11;
            // 
            // textÜrünKodu
            // 
            this.textÜrünKodu.Location = new System.Drawing.Point(134, 94);
            this.textÜrünKodu.Name = "textÜrünKodu";
            this.textÜrünKodu.Size = new System.Drawing.Size(168, 20);
            this.textÜrünKodu.TabIndex = 12;
            // 
            // textÜrünAdı
            // 
            this.textÜrünAdı.Location = new System.Drawing.Point(134, 125);
            this.textÜrünAdı.Name = "textÜrünAdı";
            this.textÜrünAdı.Size = new System.Drawing.Size(168, 20);
            this.textÜrünAdı.TabIndex = 12;
            // 
            // FrmUrunKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 502);
            this.Controls.Add(this.textÜrünAdı);
            this.Controls.Add(this.textÜrünKodu);
            this.Controls.Add(this.pictureEditResimYükle);
            this.Controls.Add(this.dateEditTarih);
            this.Controls.Add(this.memoAçıklama);
            this.Controls.Add(this.calcBirimFiyat3);
            this.Controls.Add(this.calcBirimFiyat2);
            this.Controls.Add(this.calcBirimFiyat1);
            this.Controls.Add(this.lookUpMenüŞeçimi);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrunKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kaydet";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenüŞeçimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyat1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyat2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyat3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAçıklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditResimYükle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textÜrünKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textÜrünAdı.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lookUpMenüŞeçimi;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyat1;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyat2;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyat3;
        private DevExpress.XtraEditors.MemoEdit memoAçıklama;
        private DevExpress.XtraEditors.DateEdit dateEditTarih;
        private DevExpress.XtraEditors.PictureEdit pictureEditResimYükle;
        private DevExpress.XtraEditors.TextEdit textÜrünKodu;
        private DevExpress.XtraEditors.TextEdit textÜrünAdı;
    }
}