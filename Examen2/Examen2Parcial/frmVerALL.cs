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
    public partial class frmVerALL : Form
    {
        SQLiteConnection cn;
        public static long id;
        string strComamnd;
        DataSet datos = new DataSet();
        public frmVerALL()
        {
            InitializeComponent();
        }

        private void frmVerALL_Load(object sender, EventArgs e)
        {
            datos.Clear();
            cn = conexion.getConexion();
            strComamnd = "SELECT * FROM Conductor";
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(strComamnd, cn);
            adaptador.Fill(datos, "Conductor");
            //mostrar datos en data grid
            dataGridView1.DataSource = datos.Tables["Conductor"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
