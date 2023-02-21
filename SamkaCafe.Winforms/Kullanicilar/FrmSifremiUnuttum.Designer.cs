namespace SamkaCafe.Winforms.Kullanicilar
{
    partial class FrmParolamiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParolamiUnuttum));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textKullaniciveyaeposta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textSoru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textCevap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textYeniParola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textYeniParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textKullaniciveyaeposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSoru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYeniParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYeniParolaTekrar.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(393, 35);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Parolamı Unuttum";
            // 
            // textKullaniciveyaeposta
            // 
            this.textKullaniciveyaeposta.Location = new System.Drawing.Point(139, 46);
            this.textKullaniciveyaeposta.Name = "textKullaniciveyaeposta";
            this.textKullaniciveyaeposta.Size = new System.Drawing.Size(213, 20);
            this.textKullaniciveyaeposta.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(0, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 28);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Kullanıcı Adı veya E-Mail :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 210);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(393, 100);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "İŞLEMLER";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(293, 42);
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
            this.labelControl2.Location = new System.Drawing.Point(37, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 28);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Soru :";
            // 
            // textSoru
            // 
            this.textSoru.Location = new System.Drawing.Point(139, 72);
            this.textSoru.Name = "textSoru";
            this.textSoru.Size = new System.Drawing.Size(213, 20);
            this.textSoru.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(37, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 28);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Cevap :";
            // 
            // textCevap
            // 
            this.textCevap.Location = new System.Drawing.Point(139, 98);
            this.textCevap.Name = "textCevap";
            this.textCevap.Size = new System.Drawing.Size(213, 20);
            this.textCevap.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(37, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 28);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Yeni Parola :";
            // 
            // textYeniParola
            // 
            this.textYeniParola.Location = new System.Drawing.Point(139, 124);
            this.textYeniParola.Name = "textYeniParola";
            this.textYeniParola.Properties.UseSystemPasswordChar = true;
            this.textYeniParola.Size = new System.Drawing.Size(213, 20);
            this.textYeniParola.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(37, 145);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 28);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Yeni Parola Tekrar :";
            // 
            // textYeniParolaTekrar
            // 
            this.textYeniParolaTekrar.Location = new System.Drawing.Point(139, 150);
            this.textYeniParolaTekrar.Name = "textYeniParolaTekrar";
            this.textYeniParolaTekrar.Properties.UseSystemPasswordChar = true;
            this.textYeniParolaTekrar.Size = new System.Drawing.Size(213, 20);
            this.textYeniParolaTekrar.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.25F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(-11, 176);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(381, 25);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Giriş ile ilgili problem yaşarsanız lütfen : 0545 694 30 30 numarasından bize ula" +
    "şın.";
            // 
            // FrmParolamiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 310);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.textYeniParolaTekrar);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textYeniParola);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textCevap);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textSoru);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textKullaniciveyaeposta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmParolamiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samka Yazılım-Parolamı Unuttum";
            ((System.ComponentModel.ISupportInitialize)(this.textKullaniciveyaeposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textSoru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYeniParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYeniParolaTekrar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textKullaniciveyaeposta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textSoru;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textCevap;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textYeniParola;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textYeniParolaTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}