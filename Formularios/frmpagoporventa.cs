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
    public partial class frmpagoporventa : Form
    {
        public frmpagoporventa()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCantidad.Clear();
            TxtDescto.Clear();
            TxtPagar.Clear();
            TxtPreciou.Clear();
            TxtProducto.Clear();
            TxtSubtotal.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cant, prec, sub, descto, tolp;

            cant = Convert.ToDouble(TxtCantidad.Text.Trim());
            prec = Convert.ToDouble(TxtPreciou.Text.Trim());

            sub = cant * prec;

            if (cant >= 3)
            {
                descto = sub * 0.20;
            }
            else
            {
                descto = 0;
            }

            tolp = sub - descto;

            TxtSubtotal.Text = sub.ToString();
            TxtDescto.Text = descto.ToString();
            TxtPagar.Text = tolp.ToString();
        }
    }
}
