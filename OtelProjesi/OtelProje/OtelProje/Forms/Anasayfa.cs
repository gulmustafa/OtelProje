using OtelProje.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProje
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            FrmRezervasyon frmRezervasyon = new FrmRezervasyon();
            frmRezervasyon.Show();
            this.Hide();
        }
    }
}
