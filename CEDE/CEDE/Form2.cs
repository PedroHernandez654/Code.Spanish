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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Name = txtNombre.Text;
            usuario.LastName_P = txtApellido_Paterno.Text;
            usuario.Lastname_M = txtApellido_Materno.Text;
            usuario.Id_tipo = Convert.ToInt32(NUMidtipo.Value);
            usuario.User = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            usuario.ConPassword1 = txtConPassword.Text;
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario Correctamente Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
