namespace OtelProje.Forms
{
    partial class FrmRezerveBilgileri
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
            this.PnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblOtelAdi = new System.Windows.Forms.Label();
            this.LblOdaNo = new System.Windows.Forms.Label();
            this.TbKisiSayisi = new System.Windows.Forms.TextBox();
            this.DtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.DtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.ChbSimdi = new System.Windows.Forms.CheckBox();
            this.ChbSonra = new System.Windows.Forms.CheckBox();
            this.BtnTamamla = new System.Windows.Forms.Button();
            this.LblKisiSayisi = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.pictureBox1);
            this.PnlMain.Location = new System.Drawing.Point(2, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(258, 62);
            this.PnlMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OtelProje.Properties.Resources.HOOTEL;
            this.pictureBox1.Location = new System.Drawing.Point(78, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LblOtelAdi
            // 
            this.LblOtelAdi.AutoSize = true;
            this.LblOtelAdi.Location = new System.Drawing.Point(109, 86);
            this.LblOtelAdi.Name = "LblOtelAdi";
            this.LblOtelAdi.Size = new System.Drawing.Size(47, 13);
            this.LblOtelAdi.TabIndex = 3;
            this.LblOtelAdi.Text = "Otel Adı:";
            // 
            // LblOdaNo
            // 
            this.LblOdaNo.AutoSize = true;
            this.LblOdaNo.Location = new System.Drawing.Point(109, 116);
            this.LblOdaNo.Name = "LblOdaNo";
            this.LblOdaNo.Size = new System.Drawing.Size(45, 13);
            this.LblOdaNo.TabIndex = 3;
            this.LblOdaNo.Text = "Oda no:";
            // 
            // TbKisiSayisi
            // 
            this.TbKisiSayisi.Location = new System.Drawing.Point(93, 153);
            this.TbKisiSayisi.Name = "TbKisiSayisi";
            this.TbKisiSayisi.Size = new System.Drawing.Size(138, 20);
            this.TbKisiSayisi.TabIndex = 4;
            // 
            // DtpCheckIn
            // 
            this.DtpCheckIn.Location = new System.Drawing.Point(31, 192);
            this.DtpCheckIn.Name = "DtpCheckIn";
            this.DtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.DtpCheckIn.TabIndex = 5;
            // 
            // DtpCheckOut
            // 
            this.DtpCheckOut.Location = new System.Drawing.Point(31, 218);
            this.DtpCheckOut.Name = "DtpCheckOut";
            this.DtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.DtpCheckOut.TabIndex = 5;
            // 
            // ChbSimdi
            // 
            this.ChbSimdi.AutoSize = true;
            this.ChbSimdi.Location = new System.Drawing.Point(31, 254);
            this.ChbSimdi.Name = "ChbSimdi";
            this.ChbSimdi.Size = new System.Drawing.Size(74, 17);
            this.ChbSimdi.TabIndex = 6;
            this.ChbSimdi.Text = "Şimdi Öde";
            this.ChbSimdi.UseVisualStyleBackColor = true;
            // 
            // ChbSonra
            // 
            this.ChbSonra.AutoSize = true;
            this.ChbSonra.Location = new System.Drawing.Point(154, 254);
            this.ChbSonra.Name = "ChbSonra";
            this.ChbSonra.Size = new System.Drawing.Size(77, 17);
            this.ChbSonra.TabIndex = 6;
            this.ChbSonra.Text = "Sonra Öde";
            this.ChbSonra.UseVisualStyleBackColor = true;
            // 
            // BtnTamamla
            // 
            this.BtnTamamla.Location = new System.Drawing.Point(93, 303);
            this.BtnTamamla.Name = "BtnTamamla";
            this.BtnTamamla.Size = new System.Drawing.Size(75, 23);
            this.BtnTamamla.TabIndex = 7;
            this.BtnTamamla.Text = "Tamamla";
            this.BtnTamamla.UseVisualStyleBackColor = true;
            this.BtnTamamla.Click += new System.EventHandler(this.BtnTamamla_Click);
            // 
            // LblKisiSayisi
            // 
            this.LblKisiSayisi.AutoSize = true;
            this.LblKisiSayisi.Location = new System.Drawing.Point(31, 160);
            this.LblKisiSayisi.Name = "LblKisiSayisi";
            this.LblKisiSayisi.Size = new System.Drawing.Size(56, 13);
            this.LblKisiSayisi.TabIndex = 3;
            this.LblKisiSayisi.Text = "Kişi Sayısı:";
            // 
            // FrmRezerveBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(262, 338);
            this.Controls.Add(this.BtnTamamla);
            this.Controls.Add(this.ChbSonra);
            this.Controls.Add(this.ChbSimdi);
            this.Controls.Add(this.DtpCheckOut);
            this.Controls.Add(this.DtpCheckIn);
            this.Controls.Add(this.TbKisiSayisi);
            this.Controls.Add(this.LblKisiSayisi);
            this.Controls.Add(this.LblOdaNo);
            this.Controls.Add(this.LblOtelAdi);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmRezerveBilgileri";
            this.Text = "RezerveBilgileri";
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblOtelAdi;
        private System.Windows.Forms.Label LblOdaNo;
        private System.Windows.Forms.TextBox TbKisiSayisi;
        private System.Windows.Forms.DateTimePicker DtpCheckIn;
        private System.Windows.Forms.DateTimePicker DtpCheckOut;
        private System.Windows.Forms.CheckBox ChbSimdi;
        private System.Windows.Forms.CheckBox ChbSonra;
        private System.Windows.Forms.Button BtnTamamla;
        private System.Windows.Forms.Label LblKisiSayisi;
    }
}