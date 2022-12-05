
namespace Examen2Parcial
{
    partial class frmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Regresar = new System.Windows.Forms.Button();
            this.numLicencia = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.NumIdtipo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido_Materno = new System.Windows.Forms.TextBox();
            this.txtApellido_Paterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbPassword = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLicencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIdtipo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Regresar);
            this.groupBox1.Controls.Add(this.numLicencia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.NumIdtipo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtConPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtApellido_Materno);
            this.groupBox1.Controls.Add(this.txtApellido_Paterno);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chbPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 570);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regresar.Location = new System.Drawing.Point(514, 503);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(116, 39);
            this.Regresar.TabIndex = 34;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // numLicencia
            // 
            this.numLicencia.Location = new System.Drawing.Point(287, 275);
            this.numLicencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLicencia.Name = "numLicencia";
            this.numLicencia.Size = new System.Drawing.Size(237, 33);
            this.numLicencia.TabIndex = 33;
            this.numLicencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 27);
            this.label10.TabIndex = 32;
            this.label10.Text = "Número de Licencia:";
            // 
            // NumIdtipo
            // 
            this.NumIdtipo.Location = new System.Drawing.Point(287, 236);
            this.NumIdtipo.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumIdtipo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumIdtipo.Name = "NumIdtipo";
            this.NumIdtipo.Size = new System.Drawing.Size(237, 33);
            this.NumIdtipo.TabIndex = 31;
            this.NumIdtipo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 27);
            this.label9.TabIndex = 30;
            this.label9.Text = "ID Tipo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(287, 194);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(237, 33);
            this.txtTelefono.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 27);
            this.label8.TabIndex = 28;
            this.label8.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(76, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 54);
            this.label7.TabIndex = 27;
            this.label7.Text = "*Confirme sus datos\r\nantes de registrarse\r\n\r\n";
            // 
            // txtConPassword
            // 
            this.txtConPassword.Location = new System.Drawing.Point(287, 409);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.Size = new System.Drawing.Size(237, 33);
            this.txtConPassword.TabIndex = 26;
            this.txtConPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(287, 364);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 33);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(287, 322);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(237, 33);
            this.txtUsuario.TabIndex = 24;
            // 
            // txtApellido_Materno
            // 
            this.txtApellido_Materno.Location = new System.Drawing.Point(287, 152);
            this.txtApellido_Materno.Name = "txtApellido_Materno";
            this.txtApellido_Materno.Size = new System.Drawing.Size(237, 33);
            this.txtApellido_Materno.TabIndex = 23;
            // 
            // txtApellido_Paterno
            // 
            this.txtApellido_Paterno.Location = new System.Drawing.Point(287, 110);
            this.txtApellido_Paterno.Name = "txtApellido_Paterno";
            this.txtApellido_Paterno.Size = new System.Drawing.Size(237, 33);
            this.txtApellido_Paterno.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(287, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 33);
            this.txtNombre.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(287, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 60);
            this.button1.TabIndex = 20;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbPassword
            // 
            this.chbPassword.AutoSize = true;
            this.chbPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPassword.Location = new System.Drawing.Point(287, 455);
            this.chbPassword.Name = "chbPassword";
            this.chbPassword.Size = new System.Drawing.Size(148, 21);
            this.chbPassword.TabIndex = 19;
            this.chbPassword.Text = "Mostrar Contraseña";
            this.chbPassword.UseVisualStyleBackColor = true;
            this.chbPassword.CheckedChanged += new System.EventHandler(this.chbPassword_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmar Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(s):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen2Parcial.Properties.Resources.fondo_tecnologico_preferido_selectores;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 697);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLicencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIdtipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido_Materno;
        private System.Windows.Forms.TextBox txtApellido_Paterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumIdtipo;
        private System.Windows.Forms.NumericUpDown numLicencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Regresar;
    }
}