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
    public partial class frmordendenumerosascendentes : Form
    {
        public frmordendenumerosascendentes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtAscen.Clear();
            TxtDescen.Clear();
            TxtPrimerN.Clear();
            TxtSegundoN.Clear();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            double num1, num2, ascen, descen;

            num1 = Convert.ToDouble(TxtPrimerN.Text.Trim());
            num2 = Convert.ToDouble(TxtSegundoN.Text.Trim());

            if (num1 > num2)
            {
                ascen = num2;
                descen = num1;
                TxtDescen.Text = ascen.ToString();
                TxtAscen.Text = descen.ToString();
            }
            else
            {
                ascen = num1;
                descen = num2;
                TxtDescen.Text = ascen.ToString();
                TxtAscen.Text = descen.ToString();
            }

        }
    }
}
