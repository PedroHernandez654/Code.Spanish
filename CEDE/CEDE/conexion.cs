using MySql.Data.MySqlClient;//libreria a usar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEDE
{//Se creo una clase para poder conectar la base de datos
    class conexion
    {
        public static MySqlConnection getConexion()
        {//Esto es la conexion a la base de datos
            string server = "localhost";
            string puerto = "3306";
            string user = "root";
            string password = "PedroSQL123*-";
            string bd = "sistema_usuarios";
            //cadena de conexion
            string CadenaConexion = "server=" + server + "; Port=" + puerto + "; user id=" + user + "; password=" + password + "; database=" + bd;
            //Nos conectamos a MySQL
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);
           
            return conexion;
        }

    }
}
