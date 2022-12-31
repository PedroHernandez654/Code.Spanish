using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Clases;

namespace Examen2Parcial
{
    class Modelo
    {
        //registro del usuario/conductor
        public int registro(Conductor usuario)
        {
            SQLiteConnection Conecttion = conexion.getConexion();
            Conecttion.Open();
            string sql = "INSERT INTO Conductor(Usuario, password,nombre_c,apellido_p,apellido_m,telefono,No_Licencia,id_tipo) VALUES(@Usuario, @password,@nombre_c,@apellido_p,@apellido_m,@telefono,@No_Licencia,@id_tipo)";
            SQLiteCommand comando = new SQLiteCommand(sql, Conecttion);
            comando.Parameters.AddWithValue("@Usuario",usuario.Usuario1);
            comando.Parameters.AddWithValue("@password", usuario.Password1);
            comando.Parameters.AddWithValue("@nombre_c", usuario.Nombre);
            comando.Parameters.AddWithValue("@apellido_p", usuario.Apellido_p);
            comando.Parameters.AddWithValue("@apellido_m", usuario.Apellido_m);
            comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
            comando.Parameters.AddWithValue("@No_Licencia", usuario.No_licencia);
            comando.Parameters.AddWithValue("@id_tipo", usuario.Id_tipo);
            //resultado de las filas que se ingresaron
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        //registro del vehiculo
        public int registroVeh(vehiculo vehiculo)
        {
            SQLiteConnection Conecttion = conexion.getConexion();
            Conecttion.Open();
            string sql = "INSERT INTO Vehiculo(placas,tipo,No_viajes,marca,modelo,id_conductor) VALUES(@placas,@tipo,@No_viajes,@marca,@modelo,@id_conductor)";
            SQLiteCommand comando = new SQLiteCommand(sql, Conecttion);
            comando.Parameters.AddWithValue("@placas",vehiculo.Placas);
            comando.Parameters.AddWithValue("@tipo",vehiculo.Tipo);
            comando.Parameters.AddWithValue("@No_viajes",vehiculo.No_viajes1);
            comando.Parameters.AddWithValue("@marca",vehiculo.Marca);
            comando.Parameters.AddWithValue("@modelo",vehiculo.Modelo);
            comando.Parameters.AddWithValue("@id_conductor",vehiculo.Id_conductor);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        //registro de folio
        public int registroFolio(folio folio)
        {
            SQLiteConnection Conecttion = conexion.getConexion();
            Conecttion.Open();
            string sql = "INSERT INTO Folio(Direccion, E_entrega, id_folio,id_con,id_vehiculo) VALUES(@Direccion,@E_entrega,@id_folio,@id_con,@id_vehiculo)";
            SQLiteCommand comando = new SQLiteCommand(sql, Conecttion);
            comando.Parameters.AddWithValue("@Direccion", folio.Direccion);
            comando.Parameters.AddWithValue("@E_entrega",folio.Estado_entrega1);
            comando.Parameters.AddWithValue("@id_folio", folio.Id_folio);
            comando.Parameters.AddWithValue("@id_con", folio.Id_conductorr);
            comando.Parameters.AddWithValue("@id_vehiculo",folio.Id_vehiculoo);

            int resultado = comando.ExecuteNonQuery();
            return resultado; 
        }
        //Método para verificar si el usuario ya existe en la base de datos
        public bool UsuarioExiste(string usuario)
        {
            //lee la información de la base de datos 
            SQLiteDataReader reader;
            SQLiteConnection Connection = conexion.getConexion();
            Connection.Open();
            //comandos para hacer una busqueda en la base de datos
            string sql = "SELECT id_conductor FROM conductor WHERE Usuario LIKE" + "@Usuario";
            SQLiteCommand comando = new SQLiteCommand(sql,Connection);
            comando.Parameters.AddWithValue("@Usuario",usuario);
            //leemos la información 
            reader = comando.ExecuteReader();
            //validamos la información dentro
            if (reader.HasRows) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //método para saber si ya existe el folio
        public bool folioexiste(string folio)
        {
            SQLiteDataReader reader;
            SQLiteConnection Connection = conexion.getConexion();
            Connection.Open();
            //busqueda en la base de datos
            string sql = "SELECT No_Folio FROM Folio WHERE id_folio LIKE" + "@id_folio";
            SQLiteCommand comando = new SQLiteCommand(sql, Connection);
            comando.Parameters.AddWithValue("@id_folio",folio);
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
        // método para verificar si el vehiculo ya existe dentro de la BD
        public bool vehiculoexiste(string vehiculo)
        {
            SQLiteDataReader reader;
            SQLiteConnection Connection = conexion.getConexion();
            Connection.Open();
            //busqueda en la base de datos
            string sql = "SELECT id_vehiculo FROM Vehiculo WHERE placas LIKE" + "@placas";
            SQLiteCommand comando = new SQLiteCommand(sql, Connection);
            comando.Parameters.AddWithValue("@placas", vehiculo);
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
        //Método para validar el inicio de sesión
        public Conductor ParaLog(string usuario)
        {
            SQLiteDataReader reader;
            SQLiteConnection Connection = conexion.getConexion();
            Connection.Open();
            // Comando para hacer la consulta y verificar el usuario
            string sql = "SELECT id_conductor,password,nombre_c,id_tipo FROM conductor WHERE Usuario LIKE @Usuario";
            SQLiteCommand comando = new SQLiteCommand(sql,Connection);
            comando.Parameters.AddWithValue("@Usuario",usuario);
            reader = comando.ExecuteReader();
            //variable para validar las colunas del a base de datos
            Conductor usr = null;
            while (reader.Read())//con este while vamos a validar los usuarios y la contraseña
            {
                usr = new Conductor();
                usr.Id_conductor = int.Parse(reader["id_conductor"].ToString());
                usr.Password1 = reader["password"].ToString();
                usr.Nombre = reader["nombre_c"].ToString();
                usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());
            }
            return usr; 
        }
    }
}
