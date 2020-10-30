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
    public partial class frmdetermineelmenor : Form
    {
        public frmdetermineelmenor()
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
            TxtSegundoN.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, res;

            num1 = Convert.ToDouble(TxtPrimerN.Text.Trim());
            num2 = Convert.ToDouble(TxtSegundoN.Text.Trim());

            if (num1 < num2)
            {
                res = num1;
            }
            else
            {
                res = num2;
            }

            TxtResultado.Text = res.ToString();
        }
    }
}
