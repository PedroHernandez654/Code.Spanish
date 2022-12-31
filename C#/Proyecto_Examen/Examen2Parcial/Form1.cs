using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                Carga.Text = "Cargando...  " + progressBar1.Value + "%";
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }
    }
}
