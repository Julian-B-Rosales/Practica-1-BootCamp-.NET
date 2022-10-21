using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class frm2Vectores : Form
    {
        
        public frm2Vectores()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            double[] precio = new double[8];
            precio = recibirPrecios();

            suma(precio);
        }

        private double[] recibirPrecios()
        {
            double[] precio = new double[8];
            for (int i = 0; i < 8; i++)
            {
                precio[i] = Convert.ToDouble(Interaction.InputBox("Ingrese el precio del " + (i + 1) + " producto: "));
            }

            return precio;
        }

        private void suma(double[] precio)
        {
            double ans = 0;
            for (int i = 0; i < precio.Length; i++)
            {
                ans += precio[i];
            }
            MessageBox.Show("La suma de los precios es: " + ans);
        }
    }
}
