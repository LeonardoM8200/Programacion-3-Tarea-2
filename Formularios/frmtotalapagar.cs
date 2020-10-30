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
    public partial class frmtotalapagar : Form
    {
        int contador = 1;
        public frmtotalapagar()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();

                TxtProducto.Focus();
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtProducto.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la Descripción del Producto.");
                TxtProducto.Focus();
                return;
            }

            if (TxtCantidadP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese La Cantidad de Productos.");
                TxtCantidadP.Focus();
                return;
            }

            if (TxtPrecioU.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Precio Unitario.");
                TxtPrecioU.Focus();
                return;
            }

            LsbDescripcion.Items.Add(TxtProducto.Text.Trim());
            LsbCant.Items.Add(TxtCantidadP.Text.Trim());
            LsbPrec.Items.Add(TxtPrecioU.Text.Trim());


            double cant, prec, mont, sumt;

            sumt = 0;

            cant = Convert.ToDouble(TxtCantidadP.Text);
            prec = Convert.ToDouble(TxtPrecioU.Text);

            mont = cant * prec;

            LsbMonto.Text = mont.ToString();
            LsbMonto.Items.Add(mont);

            TxtProducto.Clear();
            TxtCantidadP.Clear();
            TxtPrecioU.Clear();
            TxtProducto.Focus();

            contador++;
            LblDescripcion.Text = "Ingresar La Descripción del Producto # " + contador.ToString() + ": ";

            sumt += mont;
            TxtPagar.Text = sumt.ToString();

        }
    }
}
