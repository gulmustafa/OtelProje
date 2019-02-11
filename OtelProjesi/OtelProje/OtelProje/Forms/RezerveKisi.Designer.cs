namespace OtelProje.Forms
{
    partial class FrmRezerveKisi
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
            this.TbAdSoyad = new System.Windows.Forms.TextBox();
            this.TbNumara = new System.Windows.Forms.TextBox();
            this.BtnOnay = new System.Windows.Forms.Button();
            this.LblFiyat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblGirisTarihi = new System.Windows.Forms.Label();
            this.LblCikisTarihi = new System.Windows.Forms.Label();
            this.TbAy = new System.Windows.Forms.TextBox();
            this.TbYil = new System.Windows.Forms.TextBox();
            this.TbCvc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.pictureBox1);
            this.PnlMain.Location = new System.Drawing.Point(2, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(261, 62);
            this.PnlMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OtelProje.Properties.Resources.HOOTEL;
            this.pictureBox1.Location = new System.Drawing.Point(74, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TbAdSoyad
            // 
            this.TbAdSoyad.Location = new System.Drawing.Point(108, 100);
            this.TbAdSoyad.Name = "TbAdSoyad";
            this.TbAdSoyad.Size = new System.Drawing.Size(144, 20);
            this.TbAdSoyad.TabIndex = 3;
            // 
            // TbNumara
            // 
            this.TbNumara.Location = new System.Drawing.Point(108, 126);
            this.TbNumara.Name = "TbNumara";
            this.TbNumara.Size = new System.Drawing.Size(144, 20);
            this.TbNumara.TabIndex = 3;
            // 
            // BtnOnay
            // 
            this.BtnOnay.Location = new System.Drawing.Point(108, 208);
            this.BtnOnay.Name = "BtnOnay";
            this.BtnOnay.Size = new System.Drawing.Size(75, 23);
            this.BtnOnay.TabIndex = 4;
            this.BtnOnay.Text = "Onay";
            this.BtnOnay.UseVisualStyleBackColor = true;
            this.BtnOnay.Click += new System.EventHandler(this.BtnOnay_Click);
            // 
            // LblFiyat
            // 
            this.LblFiyat.AutoSize = true;
            this.LblFiyat.Location = new System.Drawing.Point(90, 256);
            this.LblFiyat.Name = "LblFiyat";
            this.LblFiyat.Size = new System.Drawing.Size(29, 13);
            this.LblFiyat.TabIndex = 5;
            this.LblFiyat.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fiyat:";
            // 
            // LblGirisTarihi
            // 
            this.LblGirisTarihi.AutoSize = true;
            this.LblGirisTarihi.Location = new System.Drawing.Point(90, 284);
            this.LblGirisTarihi.Name = "LblGirisTarihi";
            this.LblGirisTarihi.Size = new System.Drawing.Size(27, 13);
            this.LblGirisTarihi.TabIndex = 5;
            this.LblGirisTarihi.Text = "Giriş";
            // 
            // LblCikisTarihi
            // 
            this.LblCikisTarihi.AutoSize = true;
            this.LblCikisTarihi.Location = new System.Drawing.Point(90, 313);
            this.LblCikisTarihi.Name = "LblCikisTarihi";
            this.LblCikisTarihi.Size = new System.Drawing.Size(29, 13);
            this.LblCikisTarihi.TabIndex = 5;
            this.LblCikisTarihi.Text = "Çıkış";
            // 
            // TbAy
            // 
            this.TbAy.Location = new System.Drawing.Point(108, 171);
            this.TbAy.Name = "TbAy";
            this.TbAy.Size = new System.Drawing.Size(44, 20);
            this.TbAy.TabIndex = 6;
            // 
            // TbYil
            // 
            this.TbYil.Location = new System.Drawing.Point(158, 171);
            this.TbYil.Name = "TbYil";
            this.TbYil.Size = new System.Drawing.Size(44, 20);
            this.TbYil.TabIndex = 6;
            // 
            // TbCvc
            // 
            this.TbCvc.Location = new System.Drawing.Point(208, 171);
            this.TbCvc.Name = "TbCvc";
            this.TbCvc.Size = new System.Drawing.Size(44, 20);
            this.TbCvc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yıl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CVC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ad Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numara:";
            // 
            // FrmRezerveKisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(264, 346);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbCvc);
            this.Controls.Add(this.TbYil);
            this.Controls.Add(this.TbAy);
            this.Controls.Add(this.LblCikisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblGirisTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFiyat);
            this.Controls.Add(this.BtnOnay);
            this.Controls.Add(this.TbNumara);
            this.Controls.Add(this.TbAdSoyad);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmRezerveKisi";
            this.Text = "RezerveKisi";
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbAdSoyad;
        private System.Windows.Forms.TextBox TbNumara;
        private System.Windows.Forms.Button BtnOnay;
        private System.Windows.Forms.Label LblFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGirisTarihi;
        private System.Windows.Forms.Label LblCikisTarihi;
        private System.Windows.Forms.TextBox TbAy;
        private System.Windows.Forms.TextBox TbYil;
        private System.Windows.Forms.TextBox TbCvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}