using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProje.Forms
{
    public partial class FrmRezervasyon : Form
    {
        public FrmRezervasyon()
        {
            InitializeComponent();
        }

        private void BtnGit_Click(object sender, EventArgs e)
        {
            FrmOteller frmOteller = new FrmOteller();
            frmOteller.Show();
            this.Hide();
        }

        private void LnkLabelGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void LnkLabelUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayitOl frmKayitOl = new FrmKayitOl();
            frmKayitOl.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}
