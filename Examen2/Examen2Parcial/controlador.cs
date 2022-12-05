using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Clases;

namespace Examen2Parcial
{// esta clase es un controlador de errores en el FORMS
    class controlador
    {
        //controlador de resgistro usuario/conductor
        public string ctrlRegistro(Conductor usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(usuario.Usuario1) || string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Apellido_p) || string.IsNullOrEmpty(usuario.Apellido_m) || string.IsNullOrEmpty(usuario.Password1) || string.IsNullOrEmpty(usuario.Conpassword1) || string.IsNullOrEmpty(usuario.Telefono) || usuario.Id_tipo == 0 || usuario.No_licencia == 0)
            {
                respuesta = "Ingrese los datos en los campos correspondientes";
            }
            else
            {//comprueba la contraseña
                if (usuario.Password1 == usuario.Conpassword1)
                {
                    if (modelo.UsuarioExiste(usuario.Usuario1))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
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
        //control de registro de vehiculo
        public string ctrlRvehiculo(vehiculo vehiculo)
        {
            Conductor con = new Conductor();
            Modelo modelo = new Modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(vehiculo.Placas) || string.IsNullOrEmpty(vehiculo.Tipo) || string.IsNullOrEmpty(vehiculo.Marca) || string.IsNullOrEmpty(vehiculo.Modelo)|| vehiculo.Id_conductor==0)
            {
                respuesta = "Ingrese los datos en los campos correspondientes";
            }
            else
            {
                if (modelo.vehiculoexiste(vehiculo.Placas))
                {
                    respuesta = "El vehiculo ya existe";
                }
                else
                {
                    modelo.registroVeh(vehiculo);
                }
            }
            return respuesta;
        }
        //control registro de folios
        public string ctrlRfolio(folio folio)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(folio.Direccion) || string.IsNullOrEmpty(folio.Estado_entrega1)|| string.IsNullOrEmpty(folio.Id_folio))
            {
                respuesta = "Ingrese los datos enlos campos";
            }
            else
            {
                if (modelo.folioexiste(folio.Id_folio))
                {
                    respuesta = "el folio ya existe";
                }
                else
                {
                    modelo.registroFolio(folio);
                }
            }
            return respuesta;
        }
        //control login
        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Conductor Datos = null;
            //validamos los parametros
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                return respuesta = "Debe llenar todos los campos";
            }
            else
            {
                Datos = modelo.ParaLog(usuario);
                if (Datos == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if(Datos.Password1 != password)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                    else
                    {
                        Session.id_conductor = Datos.Id_conductor;
                        Session.usuario = Datos.Usuario1;
                        Session.nombre = Datos.Nombre;
                        Session.id_tipo = Datos.Id_tipo;
                    }
                }
            }
            return respuesta;
        }

    }

}
