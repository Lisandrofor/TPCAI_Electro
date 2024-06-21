using System;
using accesoadatos;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;




namespace Negocio
{
    public class GestorDeUsuarios
    {
        public void ValidarNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre) || nombre.Length <= 2 || nombre.Any(char.IsDigit))
            {
                throw new ArgumentException("El nombre no puede estar vacío, debe tener por lo menos 2 caracteres y no puede contener números.");
            }
        }

        public void ValidarApellido(string apellido)
        {
            if (string.IsNullOrEmpty(apellido) || apellido.Length < 2 || apellido.Any(char.IsDigit))
            {
                throw new ArgumentException("El apellido no puede estar vacío, debe tener por lo menos 2 caracteres y no puede contener números.");
            }
        }

        public void ValidarUsername(string nombre, string apellido, string nombreUsuario)
        {
            if (nombreUsuario.Length < 8)
            {
                throw new ArgumentException("El nombre de usuario debe tener mínimo 8 caracteres.");
            }
            else if (nombreUsuario.Length > 15)
            {
                throw new ArgumentException("El nombre de usuario debe tener un máximo de 15 caracteres.");
            }
            else if (nombreUsuario.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0 ||
                     nombreUsuario.IndexOf(apellido, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                throw new ArgumentException("El nombre de usuario no debe contener el nombre o el apellido.");
            }
        }
        public static string Login(Loginuser login)
        {
            // Serializar objeto Login a JSON
            string jsonRequest = JsonConvert.SerializeObject(login);

            // Llamar a WebHelper.Post para enviar la solicitud
            HttpResponseMessage response = accesoadatos.Utilidades.WebHelper.Post("Usuario/Login", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                // Manejar el error de inicio de sesión (por ejemplo, lanzar una excepción o registrar un error)
                throw new Exception("Error al iniciar sesión.");
            }

            // Leer el contenido de la respuesta
            string idUsuario = response.Content.ReadAsStringAsync().Result;

            // Se espera que la respuesta sea el ID de usuario en un inicio de sesión exitoso
            return idUsuario;
        }


    }
}
