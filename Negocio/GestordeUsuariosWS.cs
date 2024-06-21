using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoaDatos;
using Modelo;
using accesoadatos;

namespace Negocio
{
    public class GestordeUsuariosWS
    {



        public bool AgregarUsuario( string idUsuarioActual, string nombre, string apellido, int dni, string direccion, string telefono,
        string email, DateTime fechaNac, string nombreUsuario, string contraseña)
        {

            // Crear un objeto usuarioWS
            var nuevoUsuarioWS = new UsuarioWS
            {

                idUsuario = idUsuarioActual,
                nombre = nombre,
                apellido = apellido,
                dni = dni,
                direccion = direccion,
                telefono = telefono,
                email = email,
                nombreUsuario = nombreUsuario,
                contraseña = contraseña,
                fechaNacimiento = fechaNac,
                host = "test" //pasa segun opcion menu
            };

            try
            {
                UsuarioDatos.AgregarUsuario(nuevoUsuarioWS);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //public void AgregarUsuario(string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario,string contraseña)
        //{

        //    UsuarioWS usuario = new UsuarioWS(idAdministrador, "test", nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
        //    UsuarioDatos.AgregarUsuario(usuario);

        //}



    }
}
