
namespace Examen2Parcial
{
    partial class frmVerVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerVehiculos));
            this.DGVvehiculos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVvehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVvehiculos
            // 
            this.DGVvehiculos.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DGVvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVvehiculos.Location = new System.Drawing.Point(12, 12);
            this.DGVvehiculos.Name = "DGVvehiculos";
            this.DGVvehiculos.ReadOnly = true;
            this.DGVvehiculos.RowHeadersWidth = 51;
            this.DGVvehiculos.RowTemplate.Height = 24;
            this.DGVvehiculos.Size = new System.Drawing.Size(776, 426);
            this.DGVvehiculos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(343, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVerVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVvehiculos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerVehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.frmVerVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVvehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVvehiculos;
        private System.Windows.Forms.Button button1;
    }
}