using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CEDE
{
    class Controlador
    {//Esto es un controlador de errores en el código 
        public string ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if(string.IsNullOrEmpty(usuario.User) || string.IsNullOrEmpty(usuario.Name) || string.IsNullOrEmpty(usuario.LastName_P) || string.IsNullOrEmpty(usuario.Lastname_M) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword1))
            {
                respuesta = "Ingrese sus datos en los campos";
            }
            else
            {//metodo para confirmar la contraseña
                if(usuario.Password == usuario.ConPassword1)
                {//comprueba si el usuario ya existe
                    if (modelo.UserExist(usuario.User))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {//Encripta la contraseña
                        usuario.Password = generarSHA1(usuario.Password);
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Revise su contraseña";
                }
            }
            return respuesta;

        }
        //controlador del login
        public string ctrlLogin(string usuario, string passsword)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios DatosdelUsuario = null;
            //validamos si estan vacios los parametros o no
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(passsword))
            {
                return respuesta = "Debe llenar todos los campos";
            }
            else
            {
                DatosdelUsuario = modelo.ForUser(usuario);
                //validamos si el usuario que puso existe
                if (DatosdelUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if(DatosdelUsuario.Password != generarSHA1(passsword))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                    else
                    {
                        Session.id_usuario = DatosdelUsuario.Id_usuarios;
                        Session.usuario = usuario;
                        Session.nombre = DatosdelUsuario.Name;
                        Session.id_tipo = DatosdelUsuario.Id_tipo;
                    }
                }
            }
            return respuesta;
        }
        //Código para encriptar de manera más segura las contraseñas de nuestros usuarios 
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
