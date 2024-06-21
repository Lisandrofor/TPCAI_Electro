using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //WS se usa para deserializar
    //tiene todos los atributos de la response body del GET 

    public class UsuarioWS
    {
        private string _nombre, _apellido, _idusuario, _direccion, _telefono, _email, _nombreUsuario, _contraseña;
        private DateTime _fechaNacimiento;

        private string _host;
        private int _dni;
        public string Id { get; set; }
        public string idUsuario { get; set; }
        public string host { get => _host; set => _host = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public int dni { get => _dni; set => _dni = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string email { get => _email; set => _email = value; }

        public DateTime fechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public string nombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        public string contraseña { get => _contraseña; set => _contraseña = value; }


        public UsuarioWS()
        {

        }

        public override string ToString()
        {
            return string.Format("{nombre} - {apellido}.");
        }
    }


}
