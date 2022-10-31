using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNumero.Text);

            string tabla = crearTabla(n);

            
            MessageBox.Show("Los resultados de la tabla son: \n" + tabla);

        }

        private string crearTabla(int n)
        {
            string tabla = "";
            int aux;

            for (int i = 0; i <= 12; i++)
            {
                aux = n * i;
                tabla += Convert.ToString(n) + " * " + Convert.ToString(i) + " = " + Convert.ToString(aux) + "\n";
            }

            return tabla;
        } 
    }
}
