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
    public partial class FrmRezerveBilgileri : Form
    {
        public FrmRezerveBilgileri()
        {
            InitializeComponent();
        }

        private void BtnTamamla_Click(object sender, EventArgs e)
        {
            if (ChbSimdi.Checked==true)
            {
                MessageBox.Show("Rezervasyon Tamamlandı");
            }
            else if (ChbSonra.Checked==true)
            {
                FrmRezerveKisi frmRezerveKisi = new FrmRezerveKisi();
                frmRezerveKisi.Show();
                this.Hide();
            }
            
        }
    }
}
