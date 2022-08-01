namespace Formularios
{
    partial class MenuStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStock));
            this.btnAgregarNuevoProducto = new System.Windows.Forms.Button();
            this.btnRemoverProd = new System.Windows.Forms.Button();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.btnQuitarStock = new System.Windows.Forms.Button();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.btnModificarPrecio = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarNuevoProducto
            // 
            this.btnAgregarNuevoProducto.Location = new System.Drawing.Point(464, 323);
            this.btnAgregarNuevoProducto.Name = "btnAgregarNuevoProducto";
            this.btnAgregarNuevoProducto.Size = new System.Drawing.Size(156, 56);
            this.btnAgregarNuevoProducto.TabIndex = 4;
            this.btnAgregarNuevoProducto.Text = "Agregar nuevo producto";
            this.btnAgregarNuevoProducto.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoProducto.Click += new System.EventHandler(this.btnAgregarNuevoProducto_Click);
            // 
            // btnRemoverProd
            // 
            this.btnRemoverProd.Location = new System.Drawing.Point(464, 251);
            this.btnRemoverProd.Name = "btnRemoverProd";
            this.btnRemoverProd.Size = new System.Drawing.Size(156, 66);
            this.btnRemoverProd.TabIndex = 5;
            this.btnRemoverProd.Text = "Remover producto";
            this.btnRemoverProd.UseVisualStyleBackColor = true;
            this.btnRemoverProd.Click += new System.EventHandler(this.btnRemoverProd_Click);
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(464, 12);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(162, 51);
            this.btnAgregarStock.TabIndex = 6;
            this.btnAgregarStock.Text = "Agregar cantidades";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // btnQuitarStock
            // 
            this.btnQuitarStock.Location = new System.Drawing.Point(464, 69);
            this.btnQuitarStock.Name = "btnQuitarStock";
            this.btnQuitarStock.Size = new System.Drawing.Size(162, 50);
            this.btnQuitarStock.TabIndex = 7;
            this.btnQuitarStock.Text = "Quitar cantidades";
            this.btnQuitarStock.UseVisualStyleBackColor = true;
            this.btnQuitarStock.Click += new System.EventHandler(this.btnQuitarStock_Click);
            // 
            // txbStock
            // 
            this.txbStock.BackColor = System.Drawing.Color.LightGreen;
            this.txbStock.Location = new System.Drawing.Point(12, 12);
            this.txbStock.Multiline = true;
            this.txbStock.Name = "txbStock";
            this.txbStock.ReadOnly = true;
            this.txbStock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbStock.Size = new System.Drawing.Size(422, 452);
            this.txbStock.TabIndex = 8;
            // 
            // btnModificarPrecio
            // 
            this.btnModificarPrecio.Location = new System.Drawing.Point(464, 156);
            this.btnModificarPrecio.Name = "btnModificarPrecio";
            this.btnModificarPrecio.Size = new System.Drawing.Size(156, 53);
            this.btnModificarPrecio.TabIndex = 9;
            this.btnModificarPrecio.Text = "Modificar precio";
            this.btnModificarPrecio.UseVisualStyleBackColor = true;
            this.btnModificarPrecio.Click += new System.EventHandler(this.btnModificarPrecio_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(464, 425);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(156, 29);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // MenuStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarPrecio);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.btnQuitarStock);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.btnRemoverProd);
            this.Controls.Add(this.btnAgregarNuevoProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Stock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuStock_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarNuevoProducto;
        private System.Windows.Forms.Button btnRemoverProd;
        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.Button btnQuitarStock;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.Button btnModificarPrecio;
        private System.Windows.Forms.Button btnVolver;
    }
}