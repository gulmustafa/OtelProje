namespace OtelProje.Forms
{
    partial class FrmGiris
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
            this.PicBOtel = new System.Windows.Forms.PictureBox();
            this.TbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TbSifre = new System.Windows.Forms.TextBox();
            this.CheckBHatirla = new System.Windows.Forms.CheckBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSifremiUnuttum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBOtel)).BeginInit();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBOtel
            // 
            this.PicBOtel.Location = new System.Drawing.Point(1, 55);
            this.PicBOtel.Name = "PicBOtel";
            this.PicBOtel.Size = new System.Drawing.Size(260, 138);
            this.PicBOtel.TabIndex = 0;
            this.PicBOtel.TabStop = false;
            // 
            // TbKullaniciAdi
            // 
            this.TbKullaniciAdi.Location = new System.Drawing.Point(93, 199);
            this.TbKullaniciAdi.Name = "TbKullaniciAdi";
            this.TbKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.TbKullaniciAdi.TabIndex = 1;
            // 
            // TbSifre
            // 
            this.TbSifre.Location = new System.Drawing.Point(93, 225);
            this.TbSifre.Name = "TbSifre";
            this.TbSifre.Size = new System.Drawing.Size(100, 20);
            this.TbSifre.TabIndex = 1;
            // 
            // CheckBHatirla
            // 
            this.CheckBHatirla.AutoSize = true;
            this.CheckBHatirla.Location = new System.Drawing.Point(93, 261);
            this.CheckBHatirla.Name = "CheckBHatirla";
            this.CheckBHatirla.Size = new System.Drawing.Size(80, 17);
            this.CheckBHatirla.TabIndex = 2;
            this.CheckBHatirla.Text = "Beni Hatırla";
            this.CheckBHatirla.UseVisualStyleBackColor = true;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(39, 300);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(75, 23);
            this.BtnGiris.TabIndex = 3;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = true;
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.pictureBox2);
            this.PnlMain.Location = new System.Drawing.Point(1, 1);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(260, 52);
            this.PnlMain.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::OtelProje.Properties.Resources.HOOTEL;
            this.pictureBox2.Location = new System.Drawing.Point(72, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // BtnSifremiUnuttum
            // 
            this.BtnSifremiUnuttum.Location = new System.Drawing.Point(133, 300);
            this.BtnSifremiUnuttum.Name = "BtnSifremiUnuttum";
            this.BtnSifremiUnuttum.Size = new System.Drawing.Size(96, 23);
            this.BtnSifremiUnuttum.TabIndex = 3;
            this.BtnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.BtnSifremiUnuttum.UseVisualStyleBackColor = true;
            this.BtnSifremiUnuttum.Click += new System.EventHandler(this.BtnSifremiUnuttum_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(262, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.BtnSifremiUnuttum);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.CheckBHatirla);
            this.Controls.Add(this.TbSifre);
            this.Controls.Add(this.TbKullaniciAdi);
            this.Controls.Add(this.PicBOtel);
            this.Name = "FrmGiris";
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.PicBOtel)).EndInit();
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBOtel;
        private System.Windows.Forms.TextBox TbKullaniciAdi;
        private System.Windows.Forms.TextBox TbSifre;
        private System.Windows.Forms.CheckBox CheckBHatirla;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSifremiUnuttum;
    }
}