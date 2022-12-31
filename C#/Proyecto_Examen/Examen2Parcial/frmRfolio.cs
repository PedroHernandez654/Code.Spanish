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
    public partial class frmRfolio : Form
    {
        public frmRfolio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            folio folio = new folio();
            folio.Direccion = txtDireccion.Text;
            folio.Estado_entrega1 = CMBestadoe.SelectedItem.ToString();
            folio.Id_folio = txtfolio.Text;
            folio.Id_conductorr = Convert.ToInt32(NUDidcon.Value);
            folio.Id_vehiculoo = Convert.ToInt32(NUDidvehi.Value);
            try
            {
                controlador control = new controlador();
                string respuesta = control.ctrlRfolio(folio);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Folio Correctamente Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
