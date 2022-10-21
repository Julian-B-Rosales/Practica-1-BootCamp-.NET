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
    public partial class frm1Vectores : Form
    {
        public frm1Vectores()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] notas0 = new int[] {4,7,1,2};
            int[] notas1 = new int[] {1,2,5,5};
            int[] notas2 = new int[] {8,7,7,10};

            string[] alumnos = new string[] { "juan", "jorge", "cesar" };

            MessageBox.Show(" Las notas de " + alumnos[0] + " son " + String.Join("; ", notas0)
                 + "\n Su nota mas alta fue " + mayorNota(notas0) + " y su promedio es " + promedio(notas0));
            
            MessageBox.Show(" Las notas de " + alumnos[1] + " son " + String.Join("; ", notas1)
                 + "\n Su nota mas alta fue " + mayorNota(notas1) + " y su promedio es " + promedio(notas1));

            MessageBox.Show(" Las notas de " + alumnos[2] + " son " + String.Join("; ", notas2)
                 + "\n Su nota mas alta fue " + mayorNota(notas2) + " y su promedio es " + promedio(notas2));



        }

        private string mayorNota(int[] notas)
        {
            return notas.Max().ToString();
        }

        private double promedio(int[] notas)
        {
            double prom = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                prom += notas[i];
            }

            prom = prom/4;

            if (prom < 4)
            {
                MessageBox.Show("Debe ir a recuperatorio");
            }
            else if (prom >= 4 && prom < 7)
            {
                MessageBox.Show("Bien.");
            }
            else if (prom >= 7)
            {
                MessageBox.Show("Muy Bien.");
            }
            return prom;
        }
    }
}
