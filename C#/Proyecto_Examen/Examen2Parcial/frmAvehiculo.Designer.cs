
namespace Examen2Parcial
{
    partial class frmAvehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvehiculo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMBtipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NUDnumviajes = new System.Windows.Forms.NumericUpDown();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.NUDidcon = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDnumviajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDidcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NUDidcon);
            this.groupBox1.Controls.Add(this.CMBtipo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Regresar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NUDnumviajes);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtPlacas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vehículo";
            // 
            // CMBtipo
            // 
            this.CMBtipo.FormattingEnabled = true;
            this.CMBtipo.Items.AddRange(new object[] {
            "Media Tonelada",
            "Una Tonelada",
            "Tres Toneladas",
            "Trailes"});
            this.CMBtipo.Location = new System.Drawing.Point(199, 109);
            this.CMBtipo.Name = "CMBtipo";
            this.CMBtipo.Size = new System.Drawing.Size(237, 35);
            this.CMBtipo.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(40, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 72);
            this.label7.TabIndex = 36;
            this.label7.Text = "*Confirme sus datos\r\nantes de registrar \r\nel vehículo\r\n\r\n";
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regresar.Location = new System.Drawing.Point(456, 374);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(116, 39);
            this.Regresar.TabIndex = 35;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(234, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 60);
            this.button1.TabIndex = 21;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NUDnumviajes
            // 
            this.NUDnumviajes.Location = new System.Drawing.Point(199, 156);
            this.NUDnumviajes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDnumviajes.Name = "NUDnumviajes";
            this.NUDnumviajes.Size = new System.Drawing.Size(237, 34);
            this.NUDnumviajes.TabIndex = 13;
            this.NUDnumviajes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(199, 251);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(237, 34);
            this.txtModelo.TabIndex = 10;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(199, 204);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(237, 34);
            this.txtMarca.TabIndex = 9;
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(199, 57);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(237, 34);
            this.txtPlacas.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID conductor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "# Viajes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placas:";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // NUDidcon
            // 
            this.NUDidcon.Location = new System.Drawing.Point(199, 299);
            this.NUDidcon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDidcon.Name = "NUDidcon";
            this.NUDidcon.Size = new System.Drawing.Size(237, 34);
            this.NUDidcon.TabIndex = 38;
            this.NUDidcon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmAvehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen2Parcial.Properties.Resources._69931509_reparación_y_mantenimiento_de_vehículos_de_fondo_azul_transparente_vector_de_fondo_plano_con_dibujos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 564);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAvehiculo";
            this.Text = "Registro de Vehiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDnumviajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDidcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.NumericUpDown NUDnumviajes;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CMBtipo;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.NumericUpDown NUDidcon;
    }
}