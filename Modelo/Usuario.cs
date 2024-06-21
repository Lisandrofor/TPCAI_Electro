using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



namespace Modelo
{
    public abstract class Usuario
    {
        // Atributos privados
        
        public Guid Id { get; set; }
        public string host { get; set; }
        public string idUsuario { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Categoria { get; set; }
        public DateTime? FechaNacimiento { get; set; }  // ? permite null
        public DateTime? FechaBaja { get; set; }  // ? permite null
        public string NombreUsuario { get; set; }
        public int DNI { get; set; }
        public string contraseña { get; set; }
        private string nuevoPass;


        // Constructor
        public Usuario(UsuarioWS usuarioWS)
        {
            this.idUsuario = usuarioWS.Id;
            this.host = usuarioWS.host;
            this.nombre = usuarioWS.nombre;
            this.apellido = usuarioWS.apellido;
            this.DNI = usuarioWS.dni;
            this.Direccion = usuarioWS.direccion;
            this.Telefono = usuarioWS.telefono;
            this.Email = usuarioWS.email;
            this.FechaNacimiento = usuarioWS.fechaNacimiento;
            this.NombreUsuario = usuarioWS.nombreUsuario;
            this.contraseña = usuarioWS.contraseña;
        }

        public Usuario(string idUsuarioActual,string nombre, string apellido,int dni, string email, string direccion, string telefono, string categoria, DateTime fechaNac, string nombreUsuario,string contraseña)
        {
            this.idUsuario = idUsuarioActual;
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = dni;
            this.Email = email;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Categoria = categoria;
            this.FechaNacimiento = fechaNac;
            this.NombreUsuario = nombreUsuario;
            this.contraseña = contraseña;

            //this.contraseña =GenerarPasswordTemporal();

        }

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        //public string Username
        //{
        //    get { return username; }
        //    set
        //    {
        //        username = value;
        //    }
        //}

        //public string Password
        //{
        //    get { return password; }
        //    set
        //    {
        //        password = value;
        //    }
        //}

        public string NuevoPass // nueva variable para la nueva pass
        {

            get { return nuevoPass; }
            set
            {
                nuevoPass = value;
            }
        }


        // Métodos
        //public void SetPassword(string newPassword)
        //{
        //    this.password = newPassword;
        //    this.ultimoCambioPass = DateTime.Now;
        //    this.intentosCambioPass = 0;

        //    // Si el usuario pone una nueva contraseña, lo marcamos como ACTIVO
        //    this.estado = EstadoUsuario.ACTIVO;
        //}


        public string GenerarPasswordTemporal()
        {
            return "Temp1234";

        }


        override
        public String ToString()
        {
            return this.nombre + " - " + this.apellido;
        }
    }
    public class registroUsuarios: Usuario
    {

        public registroUsuarios(string idUsuarioActual,string nombre, string apellido, int dni, string email, string direccion, string telefono, string categoria, DateTime fechaNac, string nombreUsuario, string contraseña="Temp1234"):base(idUsuarioActual,nombre,apellido,dni,email,direccion,telefono,categoria,fechaNac,nombreUsuario,contraseña)
        {
            this.idUsuario = idUsuarioActual;
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = dni;
            this.Email = email;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Categoria = categoria;
            this.FechaNacimiento = fechaNac;
            this.NombreUsuario = nombreUsuario;
            this.contraseña = contraseña;

            //this.contraseña =GenerarPasswordTemporal();

        }

        



    }

    public class registroUsuarioWS:Usuario
    {
        public registroUsuarioWS(UsuarioWS usuarioWS):base(usuarioWS)
        {
            this.idUsuario = usuarioWS.Id;
            this.host = usuarioWS.host;
            this.nombre = usuarioWS.nombre;
            this.apellido = usuarioWS.apellido;
            this.DNI = usuarioWS.dni;
            this.Direccion = usuarioWS.direccion;
            this.Telefono = usuarioWS.telefono;
            this.Email = usuarioWS.email;
            this.FechaNacimiento = usuarioWS.fechaNacimiento;
            this.NombreUsuario = usuarioWS.nombreUsuario;
            this.contraseña = usuarioWS.contraseña;

        }
    }

    



    public class Lista
    {


        public static  List<Usuario> listadeUsuarios = new List<Usuario>();

        public static void AgregarUsuario(Usuario nuevoUsuario)
        {
            listadeUsuarios.Add(nuevoUsuario);
            //CargarUsuarios(listadeUsuarios);



        }


        //private static void CargarUsuarios(List<RegistroUsuario> listadeUsuarios)
        //{

        //    string docPath =




        //    using (StreamWriter registro = new StreamWriter(docPath, true))
        //    {
        //        foreach (RegistroUsuario registroUsuario in listadeUsuarios)
        //            registro.WriteLine(registroUsuario.Host + ";" + registroUsuario.IdUsuarioActual + ";" + registroUsuario.Nombre + ";" + registroUsuario.Apellido + ";" + registroUsuario.DNI + ";" + registroUsuario.Email + ";" + registroUsuario.Direccion + ";" + registroUsuario.Categoria + ";" + registroUsuario.NombreUsuario + ";" + registroUsuario.Contraseña);




        //    }



        //}







    }















    
       

       



    

       



       


    }












