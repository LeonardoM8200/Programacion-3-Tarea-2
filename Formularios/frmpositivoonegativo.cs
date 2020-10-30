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
    public partial class frmpositivoonegativo : Form
    {
        public frmpositivoonegativo()
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
            double num;
            string res;

            num = Convert.ToDouble(TxtPrimerN.Text.Trim());

            if (num >= 1)
            {
                res = "POSITIVO";
                TxtResultado.Text = res;
            }
            else
            {
                res = "NEGATIVO";
                TxtResultado.Text = res;
            }
        }
    }
}
