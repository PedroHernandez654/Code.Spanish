using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Examen2Parcial
{
    public partial class frmVerViajes : Form
    {
        SQLiteConnection cn;
        public static long id;
        string strComamnd;
        DataSet datos = new DataSet();
        public frmVerViajes()
        {
            InitializeComponent();
        }

        private void frmVerViajes_Load(object sender, EventArgs e)
        {
            datos.Clear();
            cn = conexion.getConexion();
            strComamnd = "SELECT id_conductor,id_vehiculo,marca,modelo,MAX(No_viajes) AS 'Número de viajes' FROM Vehiculo;";
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(strComamnd, cn);
            adaptador.Fill(datos, "Vehiculo");
            //mostrar datos en data grid
            DGVfolio.DataSource = datos.Tables["Vehiculo"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
