namespace Formularios
{
    partial class MenuBajaModificacionMiembro
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.btnConfirmarCambios = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(49, 32);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(125, 27);
            this.txbNombre.TabIndex = 0;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(49, 100);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(125, 27);
            this.txbApellido.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(49, 177);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(125, 27);
            this.txbEmail.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 270);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 40);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.Location = new System.Drawing.Point(241, 270);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(150, 40);
            this.btnDarDeBaja.TabIndex = 4;
            this.btnDarDeBaja.Text = "Dar de baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarCambios
            // 
            this.btnConfirmarCambios.Location = new System.Drawing.Point(241, 93);
            this.btnConfirmarCambios.Name = "btnConfirmarCambios";
            this.btnConfirmarCambios.Size = new System.Drawing.Size(150, 40);
            this.btnConfirmarCambios.TabIndex = 5;
            this.btnConfirmarCambios.Text = "Confirmar cambios";
            this.btnConfirmarCambios.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(49, 77);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(49, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "e-mail";
            // 
            // MenuBajaModificacionMiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 322);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnConfirmarCambios);
            this.Controls.Add(this.btnDarDeBaja);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Name = "MenuBajaModificacionMiembro";
            this.Text = "Menu dar de baja o modificar datos del miembro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Button btnConfirmarCambios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
    }
}