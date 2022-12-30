
namespace CEDE
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMostrarContra = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.SteelBlue;
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(167, 36);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 30);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(167, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicioSesion.Location = new System.Drawing.Point(167, 163);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(209, 50);
            this.btnInicioSesion.TabIndex = 4;
            this.btnInicioSesion.Text = "Iniciar Sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMostrarContra);
            this.groupBox1.Controls.Add(this.btnInicioSesion);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 230);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio de Sesión";
            // 
            // cbMostrarContra
            // 
            this.cbMostrarContra.AutoSize = true;
            this.cbMostrarContra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarContra.Location = new System.Drawing.Point(167, 136);
            this.cbMostrarContra.Name = "cbMostrarContra";
            this.cbMostrarContra.Size = new System.Drawing.Size(148, 21);
            this.cbMostrarContra.TabIndex = 6;
            this.cbMostrarContra.Text = "Mostrar Contraseña";
            this.cbMostrarContra.UseVisualStyleBackColor = true;
            this.cbMostrarContra.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CEDE.Properties.Resources.user_experience;
            this.pictureBox2.Location = new System.Drawing.Point(145, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(415, 363);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cbMostrarContra;
    }
}