namespace Formularios
{
    partial class MenuNuevoProdElaborado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuNuevoProdElaborado));
            this.lsbMarca = new System.Windows.Forms.ListBox();
            this.lsbTipoProdElaborado = new System.Windows.Forms.ListBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipoProdElab = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbMarca
            // 
            this.lsbMarca.FormattingEnabled = true;
            this.lsbMarca.ItemHeight = 20;
            this.lsbMarca.Location = new System.Drawing.Point(37, 211);
            this.lsbMarca.Name = "lsbMarca";
            this.lsbMarca.Size = new System.Drawing.Size(150, 24);
            this.lsbMarca.TabIndex = 0;
            // 
            // lsbTipoProdElaborado
            // 
            this.lsbTipoProdElaborado.FormattingEnabled = true;
            this.lsbTipoProdElaborado.ItemHeight = 20;
            this.lsbTipoProdElaborado.Location = new System.Drawing.Point(37, 136);
            this.lsbTipoProdElaborado.Name = "lsbTipoProdElaborado";
            this.lsbTipoProdElaborado.Size = new System.Drawing.Size(150, 24);
            this.lsbTipoProdElaborado.TabIndex = 1;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(37, 58);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(150, 27);
            this.txbNombre.TabIndex = 2;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(231, 61);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(150, 27);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(231, 136);
            this.nudPrecio.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(150, 27);
            this.nudPrecio.TabIndex = 4;
            this.nudPrecio.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(287, 188);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(94, 29);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Ivory;
            this.lblNombre.Location = new System.Drawing.Point(37, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Ivory;
            this.lblCantidad.Location = new System.Drawing.Point(231, 35);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 20);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Ivory;
            this.lblPrecio.Location = new System.Drawing.Point(231, 113);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 20);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTipoProdElab
            // 
            this.lblTipoProdElab.AutoSize = true;
            this.lblTipoProdElab.BackColor = System.Drawing.Color.Ivory;
            this.lblTipoProdElab.Location = new System.Drawing.Point(37, 113);
            this.lblTipoProdElab.Name = "lblTipoProdElab";
            this.lblTipoProdElab.Size = new System.Drawing.Size(39, 20);
            this.lblTipoProdElab.TabIndex = 10;
            this.lblTipoProdElab.Text = "Tipo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Ivory;
            this.lblMarca.Location = new System.Drawing.Point(37, 188);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca";
            // 
            // MenuNuevoProdElaborado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(403, 314);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTipoProdElab);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lsbTipoProdElaborado);
            this.Controls.Add(this.lsbMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuNuevoProdElaborado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Agregar Nuevo Producto Elaborado";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbMarca;
        private System.Windows.Forms.ListBox lsbTipoProdElaborado;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipoProdElab;
        private System.Windows.Forms.Label lblMarca;
    }
}