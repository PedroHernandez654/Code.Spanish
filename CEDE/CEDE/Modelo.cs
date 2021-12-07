using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDE
{
    class Modelo
    {   //Creamos método para insertar en la base de datos los datos
        public int registro(Usuarios usuario)
        {
            MySqlConnection Conecttion = conexion.getConexion();
            //abrimos la conexion
            Conecttion.Open();
            //Comandos SQL para insertar en la tabla usuarios
            string sql = "INSERT INTO usuarios (usuario,contraseña,nombre,apellido_Paterno,apellido_Materno,id_tipo) VALUES(@usuario,@contraseña,@nombre,@apellido_Paterno,@apellido_Materno,@id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, Conecttion);
            comando.Parameters.AddWithValue("@usuario", usuario.User);
            comando.Parameters.AddWithValue("@contraseña", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Name);
            comando.Parameters.AddWithValue("@apellido_Paterno", usuario.LastName_P);
            comando.Parameters.AddWithValue("@apellido_Materno", usuario.Lastname_M);
            comando.Parameters.AddWithValue("@id_tipo", usuario.Id_tipo);
            
            //resultado de las filas que se ingresaron
            int resultado = comando.ExecuteNonQuery();
            
            return resultado;
        }
        //creamos un metodo para validar si el usuario existe en la base de datos
        public bool UserExist(string usuario)
        {
            //Lee la información de la base de datos
            MySqlDataReader reader;
            MySqlConnection Conecttion = conexion.getConexion();
            //abrimos la conexion
            Conecttion.Open();
            //Comandos SQL para insertar en la tabla usuarios
            string sql = "SELECT id_usuario FROM usuarios WHERE usuario LIKE" + "@usuario";
            MySqlCommand comando = new MySqlCommand(sql, Conecttion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            //Lee la información de la base de datos
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //creamos un método para validar el inicio de sesion del usuario
        public Usuarios ForUser(string usuario)
        {
            //Lee la información de la base de datos
            MySqlDataReader reader;
            MySqlConnection Conecttion = conexion.getConexion();
            //abrimos la conexion
            Conecttion.Open();
            //Comandos SQL para verificar el usuario
            string sql = "SELECT id_usuario,contraseña,nombre,id_tipo FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, Conecttion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            //Lee la información de la base de datos y se transforma en el reader
            reader = comando.ExecuteReader();
            //creamos una variable de usuarios para validar en las columnas de nuestra base de datos
            Usuarios usr = null;
            while (reader.Read())//con este while vamos a validar los usuarios y la contraseña
            {
                usr = new Usuarios();//se hace un .Parsse para convertir al id a string
                usr.Id_usuarios = int.Parse(reader["id_usuario"].ToString());//convierte nuestro id en string 
                usr.Password = reader["contraseña"].ToString();//nuestra contraseña la pasa a string
                usr.Name = reader["nombre"].ToString();//Nombre a string
                usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());//Nombre a string  
               
            }
            return usr; //devolvemos la variable que tendrá todos los resultados anteriores
        }
    }

}
