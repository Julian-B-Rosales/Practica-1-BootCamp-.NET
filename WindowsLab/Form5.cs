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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Validar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string usertype = txtUsertype.Text;
            string sex = txtSex.Text;

            if (validarSexo(sex) && validarUsertype(usertype))
            {
                MessageBox.Show("El usuario es valido.\n Nombre de usuario: " + username +
                    "\n Tipo de Usuario: " + usertype + "\n Sexo: " + sex);
            }

        }

        private Boolean validarUsertype(string usertype)
        {
            if (usertype.ToUpper().Equals("ADMINISTRADOR") || usertype.ToUpper().Equals("ESTANDAR") || usertype.ToUpper().Equals("INVITADO") )
            {;
                return true;
            }
            else
            {
                MessageBox.Show("El tipo de usuario es invalido.");
            }
            return false;
        }

        private Boolean validarSexo(string sex)
        {
            if (sex.ToUpper().Equals("MASCULINO") || sex.ToUpper().Equals("FEMENINO") || sex.ToUpper().Equals("OTRO"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El sexo del usuario es invalido.");
            }
            return false;
        }
    }
}
