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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVenta));
            this.lsbProductos = new System.Windows.Forms.ListBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.elaboradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.granoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.merchandiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbTicket = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elaboradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.granoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbProductos
            // 
            this.lsbProductos.BackColor = System.Drawing.Color.LightGreen;
            this.lsbProductos.FormattingEnabled = true;
            this.lsbProductos.HorizontalScrollbar = true;
            this.lsbProductos.ItemHeight = 20;
            this.lsbProductos.Location = new System.Drawing.Point(428, 111);
            this.lsbProductos.Name = "lsbProductos";
            this.lsbProductos.Size = new System.Drawing.Size(349, 144);
            this.lsbProductos.TabIndex = 0;
            // 
            // nudCantidad
            // 
            this.nudCantidad.InterceptArrowKeys = false;
            this.nudCantidad.Location = new System.Drawing.Point(428, 303);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(198, 27);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(428, 345);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(606, 345);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(94, 29);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(746, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Ivory;
            this.lblCantidad.Location = new System.Drawing.Point(428, 271);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(272, 20);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad (peso en gramos para granos)";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.BackColor = System.Drawing.Color.LightYellow;
            this.lblDescuento.Location = new System.Drawing.Point(428, 9);
            this.lblDescuento.MaximumSize = new System.Drawing.Size(375, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(45, 20);
            this.lblDescuento.TabIndex = 7;
            this.lblDescuento.Text = "------";
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Location = new System.Drawing.Point(439, 425);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(94, 29);
            this.btnFinalizarVenta.TabIndex = 8;
            this.btnFinalizarVenta.Text = "Finalizar";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // elaboradoBindingSource
            // 
            this.elaboradoBindingSource.DataSource = typeof(Entidades.Elaborado);
            // 
            // granoBindingSource
            // 
            this.granoBindingSource.DataSource = typeof(Entidades.Grano);
            // 
            // merchandiseBindingSource
            // 
            this.merchandiseBindingSource.DataSource = typeof(Entidades.Merchandise);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 93;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 93;
            // 
            // txbTicket
            // 
            this.txbTicket.BackColor = System.Drawing.Color.LightGreen;
            this.txbTicket.Location = new System.Drawing.Point(12, 90);
            this.txbTicket.Multiline = true;
            this.txbTicket.Name = "txbTicket";
            this.txbTicket.ReadOnly = true;
            this.txbTicket.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbTicket.Size = new System.Drawing.Size(382, 403);
            this.txbTicket.TabIndex = 9;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.LightYellow;
            this.lblHora.Location = new System.Drawing.Point(24, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 20);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "----";
            // 
            // MenuVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(852, 506);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txbTicket);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lsbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Venta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuVenta_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elaboradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.granoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbProductos;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.BindingSource elaboradoBindingSource;
        private System.Windows.Forms.BindingSource granoBindingSource;
        private System.Windows.Forms.BindingSource merchandiseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txbTicket;
        private System.Windows.Forms.Label lblHora;
    }
}