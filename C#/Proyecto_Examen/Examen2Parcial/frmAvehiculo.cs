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
    public partial class frmAvehiculo : Form
    {
        public frmAvehiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehiculo vehiculo = new vehiculo();
            vehiculo.Placas = txtPlacas.Text;
            vehiculo.Tipo = CMBtipo.SelectedItem.ToString();
            vehiculo.No_viajes1 = Convert.ToInt32(NUDnumviajes.Value);
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Modelo = txtModelo.Text;
            vehiculo.Id_conductor = Convert.ToInt32(NUDidcon.Value);
            try
            {
                controlador control = new controlador();
                string respuesta = control.ctrlRvehiculo(vehiculo);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vehiculo Correctamente Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
