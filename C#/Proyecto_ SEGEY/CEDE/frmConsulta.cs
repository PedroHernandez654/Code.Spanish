using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEDE
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
            MySqlConnection Conecttion = conexion.getConexion();
            try
            {//muestra de datos en el dta grid
                Conecttion.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = Conecttion;
                command.CommandText = ("SELECT * FROM usuarios;");
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = command;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception b)
            {//Muestra error de la consulta
                MessageBox.Show(b.Message + b.StackTrace);
            }
            Conecttion.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagPrincipal frmpagprincipal = new PagPrincipal();
            frmpagprincipal.Show();
        }
    }
}
