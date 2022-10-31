using Microsoft.VisualBasic;
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
    public partial class frm3Vectores : Form
    {
        string[] todos = new string[10];
        public frm3Vectores()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            guardar(nombre);
        }

        private void guardar(string nombre)
        {
            string[] operario = new string[4];
            operario[0] = nombre;

            for (int i = 1; i <= 3; i++)
            {
                operario[i] = Interaction.InputBox("Ingrese el " + i + " sueldo");
            }

            for (int i = 0; i < todos.Length; i++)
            {
                if (todos[i] == null || todos[i] == "")
                {
                    todos[i] = operario.ToString();
                }
            }

        }
    }
}
