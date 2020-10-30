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
    public partial class frmpagodeboleteria : Form
    {
        public frmpagodeboleteria()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPagar.Clear();
            TxtCantidad.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cant, res;

            cant = Convert.ToDouble(TxtCantidad.Text.Trim());

            if (cant >= 10)
            {
                res = cant * 80.00;
            }
            else
            {
                res = cant * 100.00;
            }

            TxtPagar.Text = res.ToString();
        }
    }
}
