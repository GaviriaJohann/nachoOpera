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
    public partial class frmSuma : Form
    {
        public frmSuma()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmNachoOpera nachoOpera = new frmNachoOpera();

            nachoOpera.Show();

            this.Hide();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text != "" && txtNumero2.Text != "")
            {
                MessageBox.Show("Por favor ingrese valores correctos");
            }
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            ClassSuma classSuma = new ClassSuma();
            classSuma.Suma(numero1, numero2);

            txtNumero1.Text = "";
            txtNumero2.Text = "";    
        }
    }
}
