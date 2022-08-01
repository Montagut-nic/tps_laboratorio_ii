namespace Formularios
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnStock = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnBajaModificacionMiembro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(43, 54);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(175, 90);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Administrar Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(260, 54);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(175, 90);
            this.btnNuevaVenta.TabIndex = 1;
            this.btnNuevaVenta.Text = "Comenzar una nueva venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(43, 195);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(175, 90);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Ver historial de ventas";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // btnBajaModificacionMiembro
            // 
            this.btnBajaModificacionMiembro.Location = new System.Drawing.Point(260, 195);
            this.btnBajaModificacionMiembro.Name = "btnBajaModificacionMiembro";
            this.btnBajaModificacionMiembro.Size = new System.Drawing.Size(175, 90);
            this.btnBajaModificacionMiembro.TabIndex = 3;
            this.btnBajaModificacionMiembro.Text = " Dar de baja o Modificar datos de un cliente Miembro del Club Sano";
            this.btnBajaModificacionMiembro.UseVisualStyleBackColor = true;
            this.btnBajaModificacionMiembro.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(500, 346);
            this.Controls.Add(this.btnBajaModificacionMiembro);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.btnStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercado Sano - Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnBajaModificacionMiembro;
    }
}
