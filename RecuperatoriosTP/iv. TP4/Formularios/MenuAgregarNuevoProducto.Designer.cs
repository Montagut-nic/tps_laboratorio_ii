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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAgregarNuevoProducto));
            this.btnAgregarGrano = new System.Windows.Forms.Button();
            this.btnAgregarMerch = new System.Windows.Forms.Button();
            this.btnAgregarProdElab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarGrano
            // 
            this.btnAgregarGrano.Location = new System.Drawing.Point(22, 39);
            this.btnAgregarGrano.Name = "btnAgregarGrano";
            this.btnAgregarGrano.Size = new System.Drawing.Size(93, 55);
            this.btnAgregarGrano.TabIndex = 0;
            this.btnAgregarGrano.Text = "Agregar grano";
            this.btnAgregarGrano.UseVisualStyleBackColor = true;
            this.btnAgregarGrano.Click += new System.EventHandler(this.btnAgregarGrano_Click);
            // 
            // btnAgregarMerch
            // 
            this.btnAgregarMerch.Location = new System.Drawing.Point(195, 39);
            this.btnAgregarMerch.Name = "btnAgregarMerch";
            this.btnAgregarMerch.Size = new System.Drawing.Size(127, 58);
            this.btnAgregarMerch.TabIndex = 1;
            this.btnAgregarMerch.Text = "Agregar merchandise";
            this.btnAgregarMerch.UseVisualStyleBackColor = true;
            this.btnAgregarMerch.Click += new System.EventHandler(this.btnAgregarMerch_Click);
            // 
            // btnAgregarProdElab
            // 
            this.btnAgregarProdElab.Location = new System.Drawing.Point(382, 39);
            this.btnAgregarProdElab.Name = "btnAgregarProdElab";
            this.btnAgregarProdElab.Size = new System.Drawing.Size(148, 60);
            this.btnAgregarProdElab.TabIndex = 2;
            this.btnAgregarProdElab.Text = "Agregar producto elaborado";
            this.btnAgregarProdElab.UseVisualStyleBackColor = true;
            this.btnAgregarProdElab.Click += new System.EventHandler(this.btnAgregarProdElab_Click);
            // 
            // MenuAgregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(550, 137);
            this.Controls.Add(this.btnAgregarProdElab);
            this.Controls.Add(this.btnAgregarMerch);
            this.Controls.Add(this.btnAgregarGrano);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAgregarNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Agregar Nuevo Producto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarGrano;
        private System.Windows.Forms.Button btnAgregarMerch;
        private System.Windows.Forms.Button btnAgregarProdElab;
    }
}