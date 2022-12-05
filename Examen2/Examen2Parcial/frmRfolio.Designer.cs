
namespace Examen2Parcial
{
    partial class frmRfolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRfolio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUDidcon = new System.Windows.Forms.NumericUpDown();
            this.NUDidvehi = new System.Windows.Forms.NumericUpDown();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.CMBestadoe = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDidcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDidvehi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Regresar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CMBestadoe);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtfolio);
            this.groupBox1.Controls.Add(this.NUDidvehi);
            this.groupBox1.Controls.Add(this.NUDidcon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folio";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado de entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Folio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Conductor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Vehiculo:";
            // 
            // NUDidcon
            // 
            this.NUDidcon.Location = new System.Drawing.Point(240, 208);
            this.NUDidcon.Name = "NUDidcon";
            this.NUDidcon.Size = new System.Drawing.Size(120, 33);
            this.NUDidcon.TabIndex = 6;
            // 
            // NUDidvehi
            // 
            this.NUDidvehi.Location = new System.Drawing.Point(240, 253);
            this.NUDidvehi.Name = "NUDidvehi";
            this.NUDidvehi.Size = new System.Drawing.Size(120, 33);
            this.NUDidvehi.TabIndex = 7;
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(240, 160);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(120, 33);
            this.txtfolio.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(141, 54);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(429, 33);
            this.txtDireccion.TabIndex = 10;
            // 
            // CMBestadoe
            // 
            this.CMBestadoe.FormattingEnabled = true;
            this.CMBestadoe.Items.AddRange(new object[] {
            "Asignado",
            "Entregado"});
            this.CMBestadoe.Location = new System.Drawing.Point(240, 109);
            this.CMBestadoe.Name = "CMBestadoe";
            this.CMBestadoe.Size = new System.Drawing.Size(210, 35);
            this.CMBestadoe.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(214, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 60);
            this.button2.TabIndex = 22;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regresar.Location = new System.Drawing.Point(231, 403);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(116, 39);
            this.Regresar.TabIndex = 36;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(31, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 54);
            this.label7.TabIndex = 37;
            this.label7.Text = "*Confirme sus datos\r\nantes de registrar \r\n\r\n";
            // 
            // frmRfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen2Parcial.Properties.Resources._2b2fc1aa4f2ccea1cb908db291bd71df;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 586);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRfolio";
            this.Text = "Agregar Folio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDidcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDidvehi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDidvehi;
        private System.Windows.Forms.NumericUpDown NUDidcon;
        private System.Windows.Forms.ComboBox CMBestadoe;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label label7;
    }
}