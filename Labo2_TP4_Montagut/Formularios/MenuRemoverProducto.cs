using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class MenuRemoverProducto : Form
    {
        ArrayList listaProductos;
        public MenuRemoverProducto()
        {
            InitializeComponent();
            listaProductos = LogicaNegocio.CargarProductos();
            lsbProductos.DataSource = listaProductos;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(listaProductos is not null && lsbProductos.SelectedItem is not null)
            {
                listaProductos.Remove(lsbProductos.SelectedItem);
                LogicaNegocio.GuardarProductos(listaProductos);
                MessageBox.Show("Se ha removido el producto exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo remover el producto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult= DialogResult.Cancel;
        }

        
    }
}
