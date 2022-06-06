namespace Formularios
{
    partial class MenuVenta
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
            this.lsbProductos = new System.Windows.Forms.ListBox();
            this.txbTicketVenta = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbProductos
            // 
            this.lsbProductos.FormattingEnabled = true;
            this.lsbProductos.ItemHeight = 20;
            this.lsbProductos.Location = new System.Drawing.Point(428, 69);
            this.lsbProductos.Name = "lsbProductos";
            this.lsbProductos.Size = new System.Drawing.Size(349, 144);
            this.lsbProductos.TabIndex = 0;
            // 
            // txbTicketVenta
            // 
            this.txbTicketVenta.Location = new System.Drawing.Point(12, 12);
            this.txbTicketVenta.Multiline = true;
            this.txbTicketVenta.Name = "txbTicketVenta";
            this.txbTicketVenta.ReadOnly = true;
            this.txbTicketVenta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbTicketVenta.Size = new System.Drawing.Size(387, 426);
            this.txbTicketVenta.TabIndex = 1;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(428, 261);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(198, 27);
            this.nudCantidad.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(428, 303);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(683, 303);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(94, 29);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(683, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(428, 229);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(272, 20);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad (peso en gramos para granos)";
            // 
            // MenuVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txbTicketVenta);
            this.Controls.Add(this.lsbProductos);
            this.Name = "MenuVenta";
            this.Text = "Menu Venta";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbProductos;
        private System.Windows.Forms.TextBox txbTicketVenta;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
    }
}