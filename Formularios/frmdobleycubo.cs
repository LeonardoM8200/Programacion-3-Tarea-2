using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_LeonardoMolina.Formularios
{
    public partial class frmdobleycubo : Form
    {
        public frmdobleycubo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPrimerN.Clear();
            TxtResultado.Clear();

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double num1, res;

            num1 = Convert.ToDouble(TxtPrimerN.Text);

            if (num1 >= 10)
            {
                res = num1 * 2;
                TxtResultado.Text = res.ToString();
            }
            else
            {
                res = num1 * 3;
                TxtResultado.Text = res.ToString();
            }
        }
    }
}
