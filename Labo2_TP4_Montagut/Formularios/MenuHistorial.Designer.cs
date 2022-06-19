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
            this.txbHistorialDeVentas = new System.Windows.Forms.TextBox();
            this.btnGuardarVentas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbHistorialDeVentas
            // 
            this.txbHistorialDeVentas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txbHistorialDeVentas.ForeColor = System.Drawing.Color.Black;
            this.txbHistorialDeVentas.Location = new System.Drawing.Point(12, 21);
            this.txbHistorialDeVentas.Multiline = true;
            this.txbHistorialDeVentas.Name = "txbHistorialDeVentas";
            this.txbHistorialDeVentas.ReadOnly = true;
            this.txbHistorialDeVentas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbHistorialDeVentas.Size = new System.Drawing.Size(776, 344);
            this.txbHistorialDeVentas.TabIndex = 0;
            // 
            // btnGuardarVentas
            // 
            this.btnGuardarVentas.Location = new System.Drawing.Point(12, 391);
            this.btnGuardarVentas.Name = "btnGuardarVentas";
            this.btnGuardarVentas.Size = new System.Drawing.Size(212, 47);
            this.btnGuardarVentas.TabIndex = 1;
            this.btnGuardarVentas.Text = "Guardar ventas del mes";
            this.btnGuardarVentas.UseVisualStyleBackColor = true;
            this.btnGuardarVentas.Click += new System.EventHandler(this.btnGuardarVentas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(683, 400);
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
            this.Controls.Add(this.btnGuardarVentas);
            this.Controls.Add(this.txbHistorialDeVentas);
            this.Name = "MenuHistorial";
            this.Text = "Menu Historial de ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuHistorial_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbHistorialDeVentas;
        private System.Windows.Forms.Button btnGuardarVentas;
        private System.Windows.Forms.Button btnVolver;
    }
}