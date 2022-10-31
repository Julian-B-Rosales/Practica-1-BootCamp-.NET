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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);

            analizarEdad(edad);
        }
        private void analizarEdad(int edad)
        {
            if (edad < 18 && edad > 0)
            {
                MessageBox.Show("Usted es menor de edad");
            }
            else if (edad >= 18 && edad < 60)
            {
                MessageBox.Show("Usted es mayor de edad");
            }
            else if (edad >= 60)
            {
                MessageBox.Show("Usted en un adulto mayor");
            }
            else
            {
                MessageBox.Show("ERROR! La edad ingresada es incorrecta");
            }
        }
    }
}
