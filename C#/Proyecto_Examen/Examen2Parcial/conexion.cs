using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Examen2Parcial
{
    public class conexion
    {
        public static SQLiteConnection getConexion()
        { 
            string archivodb = "Examen2doParcial.db";
            string CadenaConexion = $"Data Source = {archivodb};Version=3;";
            SQLiteConnection conexion = new SQLiteConnection(CadenaConexion);
            return conexion;
        }
    }
}
