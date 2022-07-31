namespace Formularios
{
    partial class MenuHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHistorial));
            this.txbHistorialDeVentas = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbHistorialDeVentas
            // 
            this.txbHistorialDeVentas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txbHistorialDeVentas.ForeColor = System.Drawing.Color.Black;
            this.txbHistorialDeVentas.Location = new System.Drawing.Point(12, 12);
            this.txbHistorialDeVentas.Multiline = true;
            this.txbHistorialDeVentas.Name = "txbHistorialDeVentas";
            this.txbHistorialDeVentas.ReadOnly = true;
            this.txbHistorialDeVentas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbHistorialDeVentas.Size = new System.Drawing.Size(776, 391);
            this.txbHistorialDeVentas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(694, 409);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // MenuHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txbHistorialDeVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Historial de ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuHistorial_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbHistorialDeVentas;
        private System.Windows.Forms.Button btnVolver;
    }
}