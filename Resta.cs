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
    public partial class frmResta : Form
    {
        public frmResta()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmNachoOpera nachoOpera = new frmNachoOpera();

            nachoOpera.Show();

            this.Hide();
        }
    }
}
