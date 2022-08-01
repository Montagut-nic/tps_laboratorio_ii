namespace Formularios
{
    partial class MenuModificarPrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuModificarPrecio));
            this.lsbProductos = new System.Windows.Forms.ListBox();
            this.nudPrecioNuevo = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbProductos
            // 
            this.lsbProductos.BackColor = System.Drawing.Color.LightGreen;
            this.lsbProductos.FormattingEnabled = true;
            this.lsbProductos.HorizontalScrollbar = true;
            this.lsbProductos.ItemHeight = 20;
            this.lsbProductos.Location = new System.Drawing.Point(12, 25);
            this.lsbProductos.Name = "lsbProductos";
            this.lsbProductos.ScrollAlwaysVisible = true;
            this.lsbProductos.Size = new System.Drawing.Size(459, 224);
            this.lsbProductos.TabIndex = 0;
            // 
            // nudPrecioNuevo
            // 
            this.nudPrecioNuevo.DecimalPlaces = 2;
            this.nudPrecioNuevo.Location = new System.Drawing.Point(12, 291);
            this.nudPrecioNuevo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrecioNuevo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrecioNuevo.Name = "nudPrecioNuevo";
            this.nudPrecioNuevo.Size = new System.Drawing.Size(150, 27);
            this.nudPrecioNuevo.TabIndex = 1;
            this.nudPrecioNuevo.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Ivory;
            this.lblPrecio.Location = new System.Drawing.Point(12, 268);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(360, 334);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(94, 29);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MenuModificarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(483, 375);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nudPrecioNuevo);
            this.Controls.Add(this.lsbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuModificarPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Cambiar Precio";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioNuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbProductos;
        private System.Windows.Forms.NumericUpDown nudPrecioNuevo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}