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
            this.lsbStock = new System.Windows.Forms.ListBox();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.btnRemoverStock = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarNuevoProducto = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbStock
            // 
            this.lsbStock.FormattingEnabled = true;
            this.lsbStock.ItemHeight = 20;
            this.lsbStock.Location = new System.Drawing.Point(12, 12);
            this.lsbStock.Name = "lsbStock";
            this.lsbStock.Size = new System.Drawing.Size(768, 284);
            this.lsbStock.TabIndex = 0;
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(12, 320);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarStock.TabIndex = 1;
            this.btnAgregarStock.Text = "Agregar";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            // 
            // btnRemoverStock
            // 
            this.btnRemoverStock.Location = new System.Drawing.Point(186, 320);
            this.btnRemoverStock.Name = "btnRemoverStock";
            this.btnRemoverStock.Size = new System.Drawing.Size(94, 29);
            this.btnRemoverStock.TabIndex = 2;
            this.btnRemoverStock.Text = "Remover";
            this.btnRemoverStock.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(12, 429);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(150, 27);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.ThousandsSeparator = true;
            // 
            // btnAgregarNuevoProducto
            // 
            this.btnAgregarNuevoProducto.Location = new System.Drawing.Point(624, 429);
            this.btnAgregarNuevoProducto.Name = "btnAgregarNuevoProducto";
            this.btnAgregarNuevoProducto.Size = new System.Drawing.Size(156, 56);
            this.btnAgregarNuevoProducto.TabIndex = 4;
            this.btnAgregarNuevoProducto.Text = "Agregar nuevo producto";
            this.btnAgregarNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 394);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(272, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad (peso en gramos para granos)";
            // 
            // MenuStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnAgregarNuevoProducto);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnRemoverStock);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.lsbStock);
            this.Name = "MenuStock";
            this.Text = "Menu Stock";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbStock;
        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.Button btnRemoverStock;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregarNuevoProducto;
        private System.Windows.Forms.Label lblCantidad;
    }
}