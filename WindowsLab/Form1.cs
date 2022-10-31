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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal h = Convert.ToDecimal(txtAltura.Text);
            decimal b = Convert.ToDecimal(txtBase.Text);
            decimal ans = area(h, b);

            MessageBox.Show("El area del rectangulo es: " + ans);

        }

        private decimal area(decimal h, decimal b)
        {
            return h * b;
        }

    }
}
