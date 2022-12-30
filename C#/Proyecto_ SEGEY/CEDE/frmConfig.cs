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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GBantiV.Visible == true || GBusb.Visible == true || GBMonitor.Visible == true || GBvpn.Visible == true)
            {
                GBantiV.Visible = false;
                GBMonitor.Visible = false;
                GBantiV.Visible = false;
                GBusb.Visible = false;
                GBvpn.Visible = false;
            }else if (GPGeneral.Visible == false)
            {
                GPGeneral.Visible = true;
            }


        }

        private void antivirusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GBusb.Visible == true || GBMonitor.Visible == true || GPGeneral.Visible == true || GBvpn.Visible == true)
            {
                GBusb.Visible = false;
                GBMonitor.Visible = false;
                GBantiV.Visible = false;
                GPGeneral.Visible = false;
                GBvpn.Visible = false;
            }
            else if (GBantiV.Visible == false)
            {
                GBantiV.Visible = true;
            }
        }

        private void proteccionUSBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GBantiV.Visible == true || GBMonitor.Visible == true || GPGeneral.Visible == true || GBvpn.Visible == true)
            {
                GBantiV.Visible = false;
                GBMonitor.Visible = false;
                GBantiV.Visible = false;
                GPGeneral.Visible = false;
                GBvpn.Visible = false;
            }
            else if (GBusb.Visible == false)
            {
                GBusb.Visible = true;
            }
        }

        private void accesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GBantiV.Visible == true || GBusb.Visible == true || GBantiV.Visible == true || GPGeneral.Visible == true || GBvpn.Visible == true)
            {
                GBantiV.Visible = false;
                GBusb.Visible = false;
                GBantiV.Visible = false;
                GPGeneral.Visible = false;
                GBvpn.Visible = false;
            }
            else if (GBMonitor.Visible == false)
            {
                GBMonitor.Visible = true;
            }
        }

        private void vPNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GBusb.Visible == true || GBMonitor.Visible == true || GBantiV.Visible == true || GPGeneral.Visible == true || GBvpn.Visible == true)
            {
                GBantiV.Visible = false;
                GBMonitor.Visible = false;
                GBantiV.Visible = false;
                GPGeneral.Visible = false;
                GBusb.Visible = false;
            }
            else if (GBvpn.Visible == false)
            {
                GBvpn.Visible = true;
            }
        }

        private void GBMonitor_Enter(object sender, EventArgs e)
        {

        }
    }
}
