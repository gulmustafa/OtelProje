namespace OtelProje.Forms
{
    partial class FrmOteller
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
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblAciklama = new System.Windows.Forms.Label();
            this.LblAdres = new System.Windows.Forms.Label();
            this.LblFiyat = new System.Windows.Forms.Label();
            this.BtnRezervasyon = new System.Windows.Forms.Button();
            this.RtbOzellikler = new System.Windows.Forms.RichTextBox();
            this.PicBOtel = new System.Windows.Forms.PictureBox();
            this.LblYildizSayisi = new System.Windows.Forms.Label();
            this.BtnYorumlar = new System.Windows.Forms.Button();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBOtel)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.pictureBox1);
            this.PnlMain.Location = new System.Drawing.Point(2, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(473, 62);
            this.PnlMain.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OtelProje.Properties.Resources.HOOTEL;
            this.pictureBox1.Location = new System.Drawing.Point(172, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(9, 251);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(46, 13);
            this.LblTelefon.TabIndex = 3;
            this.LblTelefon.Text = "Telefon:";
            // 
            // LblAciklama
            // 
            this.LblAciklama.AutoSize = true;
            this.LblAciklama.Location = new System.Drawing.Point(9, 292);
            this.LblAciklama.Name = "LblAciklama";
            this.LblAciklama.Size = new System.Drawing.Size(53, 13);
            this.LblAciklama.TabIndex = 3;
            this.LblAciklama.Text = "Açıklama:";
            // 
            // LblAdres
            // 
            this.LblAdres.AutoSize = true;
            this.LblAdres.Location = new System.Drawing.Point(9, 332);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(37, 13);
            this.LblAdres.TabIndex = 3;
            this.LblAdres.Text = "Adres:";
            // 
            // LblFiyat
            // 
            this.LblFiyat.AutoSize = true;
            this.LblFiyat.Location = new System.Drawing.Point(9, 376);
            this.LblFiyat.Name = "LblFiyat";
            this.LblFiyat.Size = new System.Drawing.Size(32, 13);
            this.LblFiyat.TabIndex = 3;
            this.LblFiyat.Text = "Fiyat:";
            // 
            // BtnRezervasyon
            // 
            this.BtnRezervasyon.Location = new System.Drawing.Point(256, 411);
            this.BtnRezervasyon.Name = "BtnRezervasyon";
            this.BtnRezervasyon.Size = new System.Drawing.Size(82, 27);
            this.BtnRezervasyon.TabIndex = 4;
            this.BtnRezervasyon.Text = "Rezervasyon";
            this.BtnRezervasyon.UseVisualStyleBackColor = true;
            this.BtnRezervasyon.Click += new System.EventHandler(this.BtnRezervasyon_Click);
            // 
            // RtbOzellikler
            // 
            this.RtbOzellikler.Location = new System.Drawing.Point(256, 96);
            this.RtbOzellikler.Name = "RtbOzellikler";
            this.RtbOzellikler.Size = new System.Drawing.Size(209, 138);
            this.RtbOzellikler.TabIndex = 5;
            this.RtbOzellikler.Text = "";
            // 
            // PicBOtel
            // 
            this.PicBOtel.Location = new System.Drawing.Point(12, 96);
            this.PicBOtel.Name = "PicBOtel";
            this.PicBOtel.Size = new System.Drawing.Size(209, 138);
            this.PicBOtel.TabIndex = 2;
            this.PicBOtel.TabStop = false;
            // 
            // LblYildizSayisi
            // 
            this.LblYildizSayisi.AutoSize = true;
            this.LblYildizSayisi.Location = new System.Drawing.Point(12, 80);
            this.LblYildizSayisi.Name = "LblYildizSayisi";
            this.LblYildizSayisi.Size = new System.Drawing.Size(61, 13);
            this.LblYildizSayisi.TabIndex = 3;
            this.LblYildizSayisi.Text = "Yıldız Sayısı";
            // 
            // BtnYorumlar
            // 
            this.BtnYorumlar.Location = new System.Drawing.Point(146, 411);
            this.BtnYorumlar.Name = "BtnYorumlar";
            this.BtnYorumlar.Size = new System.Drawing.Size(75, 27);
            this.BtnYorumlar.TabIndex = 4;
            this.BtnYorumlar.Text = "Yorumlar";
            this.BtnYorumlar.UseVisualStyleBackColor = true;
            this.BtnYorumlar.Click += new System.EventHandler(this.BtnYorumlar_Click);
            // 
            // FrmOteller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.RtbOzellikler);
            this.Controls.Add(this.BtnYorumlar);
            this.Controls.Add(this.BtnRezervasyon);
            this.Controls.Add(this.LblFiyat);
            this.Controls.Add(this.LblAdres);
            this.Controls.Add(this.LblAciklama);
            this.Controls.Add(this.LblYildizSayisi);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.PicBOtel);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmOteller";
            this.Text = "Oteller";
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBOtel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicBOtel;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblAciklama;
        private System.Windows.Forms.Label LblAdres;
        private System.Windows.Forms.Label LblFiyat;
        private System.Windows.Forms.Button BtnRezervasyon;
        private System.Windows.Forms.RichTextBox RtbOzellikler;
        private System.Windows.Forms.Label LblYildizSayisi;
        private System.Windows.Forms.Button BtnYorumlar;
    }
}