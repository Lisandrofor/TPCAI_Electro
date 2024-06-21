using AccesoaDatos.Utilidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using System.Net.Http;

namespace accesoadatos
{
    public static class UsuarioDatos
    {
        //static String usuarioAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public static void AgregarUsuario(UsuarioWS usuario)
        {
            var jsonRequest = JsonConvert.SerializeObject(usuario);
            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados. Error al agregar usuario.");
            }
        }


    }








    //get para traer usuarios
    //public static List<UsuarioWS> listarusuarios()
    //{

    //    HttpResponseMessage response = WebHelper.Get("usuario/traerusuariosactivos?id=" + usuarioadmin);

    //    if (!response.IsSuccessStatusCode)
    //    {
    //        throw new Exception("verifique los datos ingresados");
    //    }
    //    else
    //    {
    //        var contentstream = response.Content.ReadAsStringAsync().Result;
    //        List<UsuarioWS> listadousuarios = JsonConvert.DeserializeObject<List<UsuarioWS>>(contentstream);
    //        return listadousuarios;

    //    }
    //}


    //patch cambiar contraseña

    //public static string cambiarcontraseña(string nombreusuario, string contraseña, string contraseñanueva)
    //{
    //    Dictionary<string, string> map = new Dictionary<string, string>();
    //    map.Add("nombreusuario", nombreusuario);
    //    map.Add("contraseña", contraseña);
    //    map.Add("contraseñanueva", contraseñanueva);

    //    var jsonrequest = JsonConvert.SerializeObject(map);

    //    HttpResponseMessage response = WebHelper.Patch("usuario/cambiarcontraseña", jsonrequest);

    //    if (!response.IsSuccessStatusCode)
    //    {
    //        throw new Exception("verifique los datos ingresados");
    //    }

    //    var reader = new StreamReader(response.Content.ReadAsStreamAsync());

    //    string respuesta = reader.ReadToEnd();

    //    return respuesta;
    //}


    //delete para baja de usuario

    //public static void borrarusuario(string idusuario, string idusuariomaster)
    //{
    //    Dictionary<string, string> map = new Dictionary<string, string>();
    //    map.Add("id", idusuario);
    //    map.Add("idusuario", idusuariomaster);

    //    var jsonrequest = JsonConvert.SerializeObject(map);

    //    HttpResponseMessage response = WebHelper.DeleteConBody("usuario/bajausuario", jsonrequest);

    //    if (!response.IsSuccessStatusCode)
    //    {
    //        throw new Exception("verifique los datos ingresados");
    //    }

    //}







}
