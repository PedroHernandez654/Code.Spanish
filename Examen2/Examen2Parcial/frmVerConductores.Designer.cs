
namespace Examen2Parcial
{
    partial class frmVerConductores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerConductores));
            this.DGVvercon = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVvercon)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVvercon
            // 
            this.DGVvercon.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DGVvercon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVvercon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVvercon.Location = new System.Drawing.Point(12, 12);
            this.DGVvercon.Name = "DGVvercon";
            this.DGVvercon.ReadOnly = true;
            this.DGVvercon.RowHeadersWidth = 51;
            this.DGVvercon.RowTemplate.Height = 24;
            this.DGVvercon.Size = new System.Drawing.Size(776, 426);
            this.DGVvercon.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(329, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVerConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVvercon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerConductores";
            this.Text = "Conductores";
            this.Load += new System.EventHandler(this.frmVerConductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVvercon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVvercon;
        private System.Windows.Forms.Button button1;
    }
}