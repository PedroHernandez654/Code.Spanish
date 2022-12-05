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
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void chbPassword_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Conductor conductor = new Conductor();
            conductor.Nombre = txtNombre.Text;
            conductor.Apellido_p = txtApellido_Paterno.Text;
            conductor.Apellido_m = txtApellido_Materno.Text;
            conductor.Telefono = txtTelefono.Text;
            conductor.Id_tipo = Convert.ToInt32(NumIdtipo.Value);
            conductor.No_licencia = Convert.ToInt32(numLicencia.Value);
            conductor.Usuario1 = txtUsuario.Text;
            conductor.Password1 = txtPassword.Text;
            conductor.Conpassword1 = txtConPassword.Text;
            try
            {
                controlador control = new controlador();
                string respuesta = control.ctrlRegistro(conductor);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario Correctamente Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
