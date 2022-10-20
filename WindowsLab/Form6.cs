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
    public partial class Form6 : Form
    {
        string nombre;
        string apellido;
        int year;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (year == null || year >= DateTime.Now.Year)
            {
                imprimir(nombre, apellido);
            }
            else
            {
                imprimir(nombre, apellido, year);
            }
        }

        private void imprimir(string nombre, string apellido)
        {
            MessageBox.Show(nombre + ", " + apellido);
        }

        private void imprimir(string nombre, string apellido, int year)
        {
            int fechaActual = DateTime.Today.Year;
            int edad = fechaActual - year;

            MessageBox.Show(nombre + " " + apellido + " tiene " + edad + " años");
        }

        private void fechaNacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            year = fechaNacimiento.SelectionRange.Start.Year;
        }
    }
}
