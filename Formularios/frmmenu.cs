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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Formularios.frmpromedio promedio1 = new frmpromedio();
            promedio1.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido A MI Programa, Leonardo Molina");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.frmpositivoonegativo positivoandnegativo = new Formularios.frmpositivoonegativo();
            positivoandnegativo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.frmdobleycubo dobleycubo = new Formularios.frmdobleycubo();
            dobleycubo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.frmpagoporventa pagoporventa = new Formularios.frmpagoporventa();
            pagoporventa.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formularios.frmordendenumerosascendentes orden = new Formularios.frmordendenumerosascendentes();
            orden.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.frmdetermineelmenor menor = new Formularios.frmdetermineelmenor();
            menor.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formularios.frmmultiposde5 multiplos = new Formularios.frmmultiposde5();
            multiplos.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formularios.frmpromediodeestudiante promedio = new Formularios.frmpromediodeestudiante();
            promedio.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.frmpagodeboleteria pagodb = new Formularios.frmpagodeboleteria();
            pagodb.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formularios.frmtotalapagar total1 = new Formularios.frmtotalapagar();
            total1.ShowDialog();
        }
    }
}
