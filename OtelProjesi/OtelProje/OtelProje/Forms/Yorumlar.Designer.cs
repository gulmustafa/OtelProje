namespace OtelProje.Forms
{
    partial class FrmYorumlar
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
            this.FlpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.TbYorumBasligi = new System.Windows.Forms.TextBox();
            this.RtbYorum = new System.Windows.Forms.RichTextBox();
            this.BtnYorumYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpContainer
            // 
            this.FlpContainer.Location = new System.Drawing.Point(2, 67);
            this.FlpContainer.Name = "FlpContainer";
            this.FlpContainer.Size = new System.Drawing.Size(356, 100);
            this.FlpContainer.TabIndex = 0;
            // 
            // TbYorumBasligi
            // 
            this.TbYorumBasligi.Location = new System.Drawing.Point(110, 190);
            this.TbYorumBasligi.Name = "TbYorumBasligi";
            this.TbYorumBasligi.Size = new System.Drawing.Size(147, 20);
            this.TbYorumBasligi.TabIndex = 1;
            // 
            // RtbYorum
            // 
            this.RtbYorum.Location = new System.Drawing.Point(110, 227);
            this.RtbYorum.Name = "RtbYorum";
            this.RtbYorum.Size = new System.Drawing.Size(147, 96);
            this.RtbYorum.TabIndex = 2;
            this.RtbYorum.Text = "";
            // 
            // BtnYorumYap
            // 
            this.BtnYorumYap.Location = new System.Drawing.Point(144, 342);
            this.BtnYorumYap.Name = "BtnYorumYap";
            this.BtnYorumYap.Size = new System.Drawing.Size(75, 23);
            this.BtnYorumYap.TabIndex = 3;
            this.BtnYorumYap.Text = "Yorum Yap";
            this.BtnYorumYap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yorum Başlığı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yorum:";
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.pictureBox1);
            this.PnlMain.Location = new System.Drawing.Point(1, 1);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(358, 52);
            this.PnlMain.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OtelProje.Properties.Resources.HOOTEL;
            this.pictureBox1.Location = new System.Drawing.Point(122, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmYorumlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(361, 390);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnYorumYap);
            this.Controls.Add(this.RtbYorum);
            this.Controls.Add(this.TbYorumBasligi);
            this.Controls.Add(this.FlpContainer);
            this.Name = "FrmYorumlar";
            this.Text = "Yorumlar";
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpContainer;
        private System.Windows.Forms.TextBox TbYorumBasligi;
        private System.Windows.Forms.RichTextBox RtbYorum;
        private System.Windows.Forms.Button BtnYorumYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}