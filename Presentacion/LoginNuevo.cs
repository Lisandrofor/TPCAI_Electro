using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Presentacion
{
    public partial class LoginNuevo : Form
    {
        public LoginNuevo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtPassword.Text;


            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingrese nombre de usuario y contraseña.");
                return;
            }


            Loginuser login = new Loginuser(nombreUsuario, contraseña);
            login.NombreUsuario = nombreUsuario;
            login.Contraseña = contraseña;


            //string idUsuario = GestorDeUsuarios.Loginuser(login);

            //if (!string.IsNullOrEmpty(idUsuario))
            //{

            //    MessageBox.Show("¡Inicio de sesión exitoso!");
            //    Form Formulario = new MenuPrincipal();
            //    Formulario.Show();
            //    Hide();
            //}
            //else
            //{

            //    MessageBox.Show("Error en el inicio de sesión. Verifique sus credenciales.");
            //}
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {

        }



    }
}
