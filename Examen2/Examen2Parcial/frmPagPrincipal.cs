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
    public partial class frmPagPrincipal : Form
    {
        int tipousuario;
        public frmPagPrincipal()
        {
            InitializeComponent();
            lblNombre.Text = Session.nombre;
            tipousuario = Session.id_tipo;
            if (tipousuario == 1)
            {
                this.submenuAcondu.Visible = true;
                this.vehiculoMenu.Visible = true;
                this.Submenugregarfolio.Visible = true;
                this.menuvertodo.Visible = true;
                this.submenuavhi.Visible = true;
            }
            else
            {
                this.submenuAcondu.Visible = false;
                this.vehiculoMenu.Visible = false;
                this.Submenugregarfolio.Visible = false;
                this.menuvertodo.Visible = false;
                this.submenuavhi.Visible = false;
            }
        }

        private void agergarConductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frmRegistroUsuario = new frmRegistroUsuario();
            frmRegistroUsuario.Visible = true;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Visible = true;
            //reiniciamos sesion
            Session ss = new Session();
        }

        private void agregarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvehiculo frmAvehiculo = new frmAvehiculo();
            frmAvehiculo.Visible = true;
        }

        private void verConductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerConductores frmVerConductores = new frmVerConductores();
            frmVerConductores.Visible = true;
        }

        private void verVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerVehiculos frmVerVehiculos = new frmVerVehiculos();
            frmVerVehiculos.Visible = true;
        }

        private void verTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerALL frmVerALL = new frmVerALL();
            frmVerALL.Visible = true;
        }

        private void Submenugregarfolio_Click(object sender, EventArgs e)
        {
            frmRfolio frmRfolio = new frmRfolio();
            frmRfolio.Visible = true;
        }

        private void verFoliosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRVfolio frmRVfolio = new frmRVfolio();
            frmRVfolio.Visible = true;
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerViajes frmVerViajes = new frmVerViajes();
            frmVerViajes.Visible = true;
        }

        private void conductoresPorVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcpv frmcpv = new frmcpv();
            frmcpv.Visible = true;
        }
    }
}
