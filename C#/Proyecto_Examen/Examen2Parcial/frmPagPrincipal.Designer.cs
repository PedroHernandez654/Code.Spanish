
namespace Examen2Parcial
{
    partial class frmPagPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conductorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuAcondu = new System.Windows.Forms.ToolStripMenuItem();
            this.verConductoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuvertodo = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuavhi = new System.Windows.Forms.ToolStripMenuItem();
            this.verVehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenugregarfolio = new System.Windows.Forms.ToolStripMenuItem();
            this.verFoliosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conductoresPorVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conductorMenu,
            this.vehiculoMenu,
            this.folioToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1013, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conductorMenu
            // 
            this.conductorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuAcondu,
            this.verConductoresToolStripMenuItem,
            this.menuvertodo});
            this.conductorMenu.Name = "conductorMenu";
            this.conductorMenu.Size = new System.Drawing.Size(92, 24);
            this.conductorMenu.Text = "Conductor";
            // 
            // submenuAcondu
            // 
            this.submenuAcondu.Name = "submenuAcondu";
            this.submenuAcondu.Size = new System.Drawing.Size(224, 26);
            this.submenuAcondu.Text = "Agergar Conductor";
            this.submenuAcondu.Click += new System.EventHandler(this.agergarConductorToolStripMenuItem_Click);
            // 
            // verConductoresToolStripMenuItem
            // 
            this.verConductoresToolStripMenuItem.Name = "verConductoresToolStripMenuItem";
            this.verConductoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verConductoresToolStripMenuItem.Text = "Ver Conductores";
            this.verConductoresToolStripMenuItem.Click += new System.EventHandler(this.verConductoresToolStripMenuItem_Click);
            // 
            // menuvertodo
            // 
            this.menuvertodo.Name = "menuvertodo";
            this.menuvertodo.Size = new System.Drawing.Size(224, 26);
            this.menuvertodo.Text = "Ver Todo";
            this.menuvertodo.Click += new System.EventHandler(this.verTodoToolStripMenuItem_Click);
            // 
            // vehiculoMenu
            // 
            this.vehiculoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuavhi,
            this.verVehículosToolStripMenuItem});
            this.vehiculoMenu.Name = "vehiculoMenu";
            this.vehiculoMenu.Size = new System.Drawing.Size(79, 24);
            this.vehiculoMenu.Text = "Vehículo";
            // 
            // submenuavhi
            // 
            this.submenuavhi.Name = "submenuavhi";
            this.submenuavhi.Size = new System.Drawing.Size(224, 26);
            this.submenuavhi.Text = "Agregar Vehículo";
            this.submenuavhi.Click += new System.EventHandler(this.agregarVehículoToolStripMenuItem_Click);
            // 
            // verVehículosToolStripMenuItem
            // 
            this.verVehículosToolStripMenuItem.Name = "verVehículosToolStripMenuItem";
            this.verVehículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verVehículosToolStripMenuItem.Text = "Ver Vehículos";
            this.verVehículosToolStripMenuItem.Click += new System.EventHandler(this.verVehículosToolStripMenuItem_Click);
            // 
            // folioToolStripMenuItem
            // 
            this.folioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenugregarfolio,
            this.verFoliosToolStripMenuItem});
            this.folioToolStripMenuItem.Name = "folioToolStripMenuItem";
            this.folioToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.folioToolStripMenuItem.Text = "Folio";
            // 
            // Submenugregarfolio
            // 
            this.Submenugregarfolio.Name = "Submenugregarfolio";
            this.Submenugregarfolio.Size = new System.Drawing.Size(183, 26);
            this.Submenugregarfolio.Text = "Agregar Folio";
            this.Submenugregarfolio.Click += new System.EventHandler(this.Submenugregarfolio_Click);
            // 
            // verFoliosToolStripMenuItem
            // 
            this.verFoliosToolStripMenuItem.Name = "verFoliosToolStripMenuItem";
            this.verFoliosToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.verFoliosToolStripMenuItem.Text = "Ver Folios";
            this.verFoliosToolStripMenuItem.Click += new System.EventHandler(this.verFoliosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajesToolStripMenuItem,
            this.conductoresPorVehiculoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.viajesToolStripMenuItem.Text = "Viajes por vehículo";
            this.viajesToolStripMenuItem.Click += new System.EventHandler(this.viajesToolStripMenuItem_Click);
            // 
            // conductoresPorVehiculoToolStripMenuItem
            // 
            this.conductoresPorVehiculoToolStripMenuItem.Name = "conductoresPorVehiculoToolStripMenuItem";
            this.conductoresPorVehiculoToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.conductoresPorVehiculoToolStripMenuItem.Text = "Conductores por vehiculo";
            this.conductoresPorVehiculoToolStripMenuItem.Click += new System.EventHandler(this.conductoresPorVehiculoToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(136, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(39, 27);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "***";
            // 
            // frmPagPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen2Parcial.Properties.Resources.zarla_cleanquick_1x1_2400x2400_20210614_g94q9xxvfmq6k884q737;
            this.ClientSize = new System.Drawing.Size(1013, 516);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPagPrincipal";
            this.Text = "Página Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conductorMenu;
        private System.Windows.Forms.ToolStripMenuItem submenuAcondu;
        private System.Windows.Forms.ToolStripMenuItem verConductoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoMenu;
        private System.Windows.Forms.ToolStripMenuItem submenuavhi;
        private System.Windows.Forms.ToolStripMenuItem verVehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Submenugregarfolio;
        private System.Windows.Forms.ToolStripMenuItem verFoliosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuvertodo;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conductoresPorVehiculoToolStripMenuItem;
    }
}