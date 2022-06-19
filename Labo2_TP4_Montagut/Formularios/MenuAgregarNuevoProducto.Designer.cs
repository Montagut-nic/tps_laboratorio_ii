namespace Formularios
{
    partial class MenuAgregarNuevoProducto
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
            this.btnAgregarNuevoProducto = new System.Windows.Forms.Button();
            this.gpbClaseDeProucto = new System.Windows.Forms.GroupBox();
            this.rdbMerchandise = new System.Windows.Forms.RadioButton();
            this.rdbGranos = new System.Windows.Forms.RadioButton();
            this.rdbProductoElaborado = new System.Windows.Forms.RadioButton();
            this.cmbETipoDeProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoDeProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMarcaDelPorducto = new System.Windows.Forms.Label();
            this.cmbEMarca = new System.Windows.Forms.ComboBox();
            this.lblTalle = new System.Windows.Forms.Label();
            this.cmbETalle = new System.Windows.Forms.ComboBox();
            this.gpbClaseDeProucto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarNuevoProducto
            // 
            this.btnAgregarNuevoProducto.Location = new System.Drawing.Point(485, 307);
            this.btnAgregarNuevoProducto.Name = "btnAgregarNuevoProducto";
            this.btnAgregarNuevoProducto.Size = new System.Drawing.Size(150, 60);
            this.btnAgregarNuevoProducto.TabIndex = 0;
            this.btnAgregarNuevoProducto.Text = "Agregar nuevo producto";
            this.btnAgregarNuevoProducto.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoProducto.Click += new System.EventHandler(this.btnAgregarNuevoProducto_Click);
            // 
            // gpbClaseDeProucto
            // 
            this.gpbClaseDeProucto.Controls.Add(this.rdbMerchandise);
            this.gpbClaseDeProucto.Controls.Add(this.rdbGranos);
            this.gpbClaseDeProucto.Controls.Add(this.rdbProductoElaborado);
            this.gpbClaseDeProucto.Location = new System.Drawing.Point(12, 12);
            this.gpbClaseDeProucto.Name = "gpbClaseDeProucto";
            this.gpbClaseDeProucto.Size = new System.Drawing.Size(203, 167);
            this.gpbClaseDeProucto.TabIndex = 1;
            this.gpbClaseDeProucto.TabStop = false;
            // 
            // rdbMerchandise
            // 
            this.rdbMerchandise.AutoSize = true;
            this.rdbMerchandise.Location = new System.Drawing.Point(6, 119);
            this.rdbMerchandise.Name = "rdbMerchandise";
            this.rdbMerchandise.Size = new System.Drawing.Size(114, 24);
            this.rdbMerchandise.TabIndex = 2;
            this.rdbMerchandise.TabStop = true;
            this.rdbMerchandise.Text = "Merchandise";
            this.rdbMerchandise.UseVisualStyleBackColor = true;
            // 
            // rdbGranos
            // 
            this.rdbGranos.AutoSize = true;
            this.rdbGranos.Location = new System.Drawing.Point(6, 73);
            this.rdbGranos.Name = "rdbGranos";
            this.rdbGranos.Size = new System.Drawing.Size(76, 24);
            this.rdbGranos.TabIndex = 1;
            this.rdbGranos.TabStop = true;
            this.rdbGranos.Text = "Granos";
            this.rdbGranos.UseVisualStyleBackColor = true;
            // 
            // rdbProductoElaborado
            // 
            this.rdbProductoElaborado.AutoSize = true;
            this.rdbProductoElaborado.Location = new System.Drawing.Point(6, 26);
            this.rdbProductoElaborado.Name = "rdbProductoElaborado";
            this.rdbProductoElaborado.Size = new System.Drawing.Size(163, 24);
            this.rdbProductoElaborado.TabIndex = 0;
            this.rdbProductoElaborado.TabStop = true;
            this.rdbProductoElaborado.Text = "Producto elaborado";
            this.rdbProductoElaborado.UseVisualStyleBackColor = true;
            // 
            // cmbETipoDeProducto
            // 
            this.cmbETipoDeProducto.FormattingEnabled = true;
            this.cmbETipoDeProducto.Location = new System.Drawing.Point(251, 38);
            this.cmbETipoDeProducto.Name = "cmbETipoDeProducto";
            this.cmbETipoDeProducto.Size = new System.Drawing.Size(151, 28);
            this.cmbETipoDeProducto.TabIndex = 2;
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.AutoSize = true;
            this.lblTipoDeProducto.Location = new System.Drawing.Point(251, 9);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(39, 20);
            this.lblTipoDeProducto.TabIndex = 3;
            this.lblTipoDeProducto.Text = "Tipo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 198);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(272, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad (peso en gramos para granos)";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(12, 221);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(150, 27);
            this.nudCantidad.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 307);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 60);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblMarcaDelPorducto
            // 
            this.lblMarcaDelPorducto.AutoSize = true;
            this.lblMarcaDelPorducto.Location = new System.Drawing.Point(494, 9);
            this.lblMarcaDelPorducto.Name = "lblMarcaDelPorducto";
            this.lblMarcaDelPorducto.Size = new System.Drawing.Size(50, 20);
            this.lblMarcaDelPorducto.TabIndex = 7;
            this.lblMarcaDelPorducto.Text = "Marca";
            // 
            // cmbEMarca
            // 
            this.cmbEMarca.FormattingEnabled = true;
            this.cmbEMarca.Location = new System.Drawing.Point(494, 38);
            this.cmbEMarca.Name = "cmbEMarca";
            this.cmbEMarca.Size = new System.Drawing.Size(151, 28);
            this.cmbEMarca.TabIndex = 8;
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.Location = new System.Drawing.Point(494, 106);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(39, 20);
            this.lblTalle.TabIndex = 9;
            this.lblTalle.Text = "Talle";
            // 
            // cmbETalle
            // 
            this.cmbETalle.FormattingEnabled = true;
            this.cmbETalle.Location = new System.Drawing.Point(494, 131);
            this.cmbETalle.Name = "cmbETalle";
            this.cmbETalle.Size = new System.Drawing.Size(151, 28);
            this.cmbETalle.TabIndex = 10;
            // 
            // MenuAgregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 403);
            this.Controls.Add(this.cmbETalle);
            this.Controls.Add(this.lblTalle);
            this.Controls.Add(this.cmbEMarca);
            this.Controls.Add(this.lblMarcaDelPorducto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTipoDeProducto);
            this.Controls.Add(this.cmbETipoDeProducto);
            this.Controls.Add(this.gpbClaseDeProucto);
            this.Controls.Add(this.btnAgregarNuevoProducto);
            this.Name = "MenuAgregarNuevoProducto";
            this.Text = "Menu agregar nuevo producto";
            this.gpbClaseDeProucto.ResumeLayout(false);
            this.gpbClaseDeProucto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNuevoProducto;
        private System.Windows.Forms.GroupBox gpbClaseDeProucto;
        private System.Windows.Forms.RadioButton rdbProductoElaborado;
        private System.Windows.Forms.ComboBox cmbETipoDeProducto;
        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.RadioButton rdbGranos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMarcaDelPorducto;
        private System.Windows.Forms.ComboBox cmbEMarca;
        private System.Windows.Forms.Label lblTalle;
        private System.Windows.Forms.ComboBox cmbETalle;
        private System.Windows.Forms.RadioButton rdbMerchandise;
    }
}