namespace Formularios
{
    partial class MenuNuevoMiembro
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
            this.txbMail = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(21, 54);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(175, 27);
            this.txbNombre.TabIndex = 0;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(224, 54);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(175, 27);
            this.txbApellido.TabIndex = 1;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(21, 160);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(175, 27);
            this.txbMail.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(224, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 27);
            this.textBox4.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(224, 31);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(21, 127);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(52, 20);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "E-mail";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(224, 127);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 20);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID/DNI";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(305, 229);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(94, 29);
            this.btnContinuar.TabIndex = 8;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(21, 229);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // MenuNuevoMiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 285);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Name = "MenuNuevoMiembro";
            this.Text = "Menu Nuevo Miembro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnVolver;
    }
}