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
    public partial class frmVerConductores : Form
    {
        SQLiteConnection cn;
        public static long id;
        string strComamnd;
        DataSet datos = new DataSet();
        public frmVerConductores()
        {
            InitializeComponent();
        }

        private void frmVerConductores_Load(object sender, EventArgs e)
        {
            datos.Clear();
            cn = conexion.getConexion();
            strComamnd = "SELECT * FROM Conductor WHERE id_tipo=2";
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(strComamnd, cn);
            adaptador.Fill(datos, "Conductor");
            //mostrar datos en data grid
            DGVvercon.DataSource = datos.Tables["Conductor"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
