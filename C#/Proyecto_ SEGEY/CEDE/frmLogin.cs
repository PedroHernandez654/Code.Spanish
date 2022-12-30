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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {//este es el botónd de inicio de sesión 
            string usuario = txtUser.Text;
            string password = txtPassword.Text;

            try
            {
                Controlador ctrl = new Controlador();
                string respuesta = ctrl.ctrlLogin(usuario,password);
                //validamos si la respuesta nos envia algo
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    PagPrincipal frmpagprincipal = new PagPrincipal();
                    frmpagprincipal.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarContra.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
