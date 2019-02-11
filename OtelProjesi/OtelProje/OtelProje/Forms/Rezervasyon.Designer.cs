namespace OtelProje.Forms
{
    partial class FrmRezervasyon
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
            this.LnkLabelGiris = new System.Windows.Forms.LinkLabel();
            this.LnkLabelUyeOl = new System.Windows.Forms.LinkLabel();
            this.TbAra = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.DtpGiris = new System.Windows.Forms.DateTimePicker();
            this.DtpCikis = new System.Windows.Forms.DateTimePicker();
            this.CbOdaSecim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvOteller = new System.Windows.Forms.DataGridView();
            this.BtnGit = new System.Windows.Forms.Button();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOteller)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.pictureBox1);
            this.PnlMain.Controls.Add(this.LnkLabelGiris);
            this.PnlMain.Controls.Add(this.LnkLabelUyeOl);
            this.PnlMain.Location = new System.Drawing.Point(2, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(796, 62);
            this.PnlMain.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OtelProje.Properties.Resources.HOOTEL;
            this.pictureBox1.Location = new System.Drawing.Point(335, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // LnkLabelGiris
            // 
            this.LnkLabelGiris.AutoSize = true;
            this.LnkLabelGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkLabelGiris.Location = new System.Drawing.Point(672, 21);
            this.LnkLabelGiris.Name = "LnkLabelGiris";
            this.LnkLabelGiris.Size = new System.Drawing.Size(41, 20);
            this.LnkLabelGiris.TabIndex = 0;
            this.LnkLabelGiris.TabStop = true;
            this.LnkLabelGiris.Text = "Giriş";
            this.LnkLabelGiris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLabelGiris_LinkClicked);
            // 
            // LnkLabelUyeOl
            // 
            this.LnkLabelUyeOl.AutoSize = true;
            this.LnkLabelUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkLabelUyeOl.Location = new System.Drawing.Point(722, 21);
            this.LnkLabelUyeOl.Name = "LnkLabelUyeOl";
            this.LnkLabelUyeOl.Size = new System.Drawing.Size(56, 20);
            this.LnkLabelUyeOl.TabIndex = 0;
            this.LnkLabelUyeOl.TabStop = true;
            this.LnkLabelUyeOl.Text = "Üye Ol";
            this.LnkLabelUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLabelUyeOl_LinkClicked);
            // 
            // TbAra
            // 
            this.TbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbAra.Location = new System.Drawing.Point(75, 69);
            this.TbAra.Multiline = true;
            this.TbAra.Name = "TbAra";
            this.TbAra.Size = new System.Drawing.Size(576, 36);
            this.TbAra.TabIndex = 1;
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(657, 69);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(75, 36);
            this.BtnAra.TabIndex = 2;
            this.BtnAra.Text = "ARA";
            this.BtnAra.UseVisualStyleBackColor = true;
            // 
            // DtpGiris
            // 
            this.DtpGiris.Location = new System.Drawing.Point(75, 124);
            this.DtpGiris.Name = "DtpGiris";
            this.DtpGiris.Size = new System.Drawing.Size(200, 20);
            this.DtpGiris.TabIndex = 3;
            this.DtpGiris.Tag = "";
            // 
            // DtpCikis
            // 
            this.DtpCikis.Location = new System.Drawing.Point(281, 124);
            this.DtpCikis.Name = "DtpCikis";
            this.DtpCikis.Size = new System.Drawing.Size(200, 20);
            this.DtpCikis.TabIndex = 3;
            // 
            // CbOdaSecim
            // 
            this.CbOdaSecim.FormattingEnabled = true;
            this.CbOdaSecim.Items.AddRange(new object[] {
            "Tek Kişilik",
            "Çift Kişilik",
            "Lüks",
            "Kral Dairesi"});
            this.CbOdaSecim.Location = new System.Drawing.Point(487, 123);
            this.CbOdaSecim.Name = "CbOdaSecim";
            this.CbOdaSecim.Size = new System.Drawing.Size(164, 21);
            this.CbOdaSecim.TabIndex = 4;
            this.CbOdaSecim.Text = "Çift Kişilik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Çıkış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oda Seçimi";
            // 
            // DgvOteller
            // 
            this.DgvOteller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOteller.Location = new System.Drawing.Point(75, 160);
            this.DgvOteller.Name = "DgvOteller";
            this.DgvOteller.Size = new System.Drawing.Size(657, 278);
            this.DgvOteller.TabIndex = 6;
            // 
            // BtnGit
            // 
            this.BtnGit.Location = new System.Drawing.Point(738, 377);
            this.BtnGit.Name = "BtnGit";
            this.BtnGit.Size = new System.Drawing.Size(56, 23);
            this.BtnGit.TabIndex = 7;
            this.BtnGit.Text = "Git";
            this.BtnGit.UseVisualStyleBackColor = true;
            this.BtnGit.Click += new System.EventHandler(this.BtnGit_Click);
            // 
            // FrmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGit);
            this.Controls.Add(this.DgvOteller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbOdaSecim);
            this.Controls.Add(this.DtpCikis);
            this.Controls.Add(this.DtpGiris);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TbAra);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmRezervasyon";
            this.Text = "Rezervasyon";
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOteller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LnkLabelGiris;
        private System.Windows.Forms.LinkLabel LnkLabelUyeOl;
        private System.Windows.Forms.TextBox TbAra;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.DateTimePicker DtpGiris;
        private System.Windows.Forms.DateTimePicker DtpCikis;
        private System.Windows.Forms.ComboBox CbOdaSecim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvOteller;
        private System.Windows.Forms.Button BtnGit;
    }
}