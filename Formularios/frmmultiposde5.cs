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
    public partial class frmmultiposde5 : Form
    {
        public frmmultiposde5()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 5; i <= 300; i += 5)
            {
                TxtResultado.Text = TxtResultado.Text + i.ToString() + " - ";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();

                TxtResultado.Focus();
            }
        }
    }
}
