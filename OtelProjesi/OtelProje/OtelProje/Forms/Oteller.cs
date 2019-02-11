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
    public partial class FrmOteller : Form
    {
        public FrmOteller()
        {
            InitializeComponent();
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            FrmRezerveBilgileri frmRezerveBilgileri = new FrmRezerveBilgileri();
            frmRezerveBilgileri.Show();
            this.Hide();
        }

        private void BtnYorumlar_Click(object sender, EventArgs e)
        {
            FrmYorumlar frmYorumlar = new FrmYorumlar();
            frmYorumlar.Show();
            this.Hide();
        }
    }
}
