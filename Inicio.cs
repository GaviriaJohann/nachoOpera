using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nachoOpera
{
    public partial class frmNachoOpera : Form
    {
        public frmNachoOpera()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            frmSuma suma = new frmSuma();

            suma.Show();

            this.Hide();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            frmResta resta = new frmResta();

            resta.Show();

            this.Hide();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            frmMulti multi = new frmMulti();

            multi.Show();

            this.Hide();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            frmDivision division = new frmDivision();

            division.Show();

            this.Hide();
        }
    }
}
