using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            decimal area = areaRectangulo(b, h);

            MessageBox.Show("El area del rectangulo es: " + area);
        }

        private decimal areaRectangulo(decimal b, decimal h) { 
            return b * h;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(Interaction.InputBox("Ingrese la medida del diametro: "));

            double area =  areaCirculo(d);

            MessageBox.Show("El area del circulo es: " + area);
        }

        private double areaCirculo(double d) {
            return Math.PI * Math.Pow(d / 2, 2);
        }


        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            decimal bGrande = Convert.ToDecimal(Interaction.InputBox("Ingrese la medida de la base mas grande: "));
            decimal bChica = Convert.ToDecimal(Interaction.InputBox("Ingrese la medida de la base mas chica: "));
            decimal h = Convert.ToDecimal(Interaction.InputBox("Ingrese la medida de la altura: "));
            decimal area = areaTrapecio(bGrande, bChica, h);

            MessageBox.Show("El area del trapecio es: " + area);
        }

        private decimal areaTrapecio(decimal bGrande, decimal bChica, decimal h) {
            return (bGrande + bChica) * h / 2;
        }
         

    }
}
