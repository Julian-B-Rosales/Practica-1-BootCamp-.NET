using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            decimal b = Convert.ToDecimal(Interaction.InputBox("Ingrese la medida de la base: "));
            decimal h = Convert.ToDecimal(Interaction.InputBox("Ingrese la medida de la altura: "));
            decimal area = b * h;

            MessageBox.Show("El area del rectangulo es: " + area);
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(Interaction.InputBox("Ingrese la medida del diametro: "));

            double area =  Math.PI * Math.Pow(d/2,2);

            MessageBox.Show("El area del circulo es: " + area);
        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            decimal bGrande = Convert.ToDecimal(Interaction.InputBox("Ingrese la medida de la base mas grande: "));
            decimal bChica = Convert.ToDecimal(Interaction.InputBox("Ingrese la medida de la base mas chica: "));
            decimal h = Convert.ToDecimal(Interaction.InputBox("Ingrese la medida de la altura: "));
            decimal area = (bGrande + bChica) * h / 2;

            MessageBox.Show("El area del trapecio es: " + area);
        }
    }
}
