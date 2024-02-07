using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nota2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNota3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(txtNota1.Text);
           int nota2 = int.Parse(txtNota2.Text);
           int nota3 = int.Parse(txtNota3.Text);
            int nota4 = int.Parse(txtNota4.Text);

           float promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            txtPromedio.Text = "Promedio: " + promedio.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            txtNota4.Text = string.Empty;
            txtPromedio.Text = string.Empty;
        }
    }
}
