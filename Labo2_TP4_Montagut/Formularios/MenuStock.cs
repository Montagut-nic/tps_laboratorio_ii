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
    public partial class MenuStock : Form
    {
        ArrayList productosList;
        public MenuStock()
        {
            InitializeComponent();
            Serializador serializador = new Serializador();
            productosList = serializador.Leer();
            ActualizarTxbStock();
        }

        private void btnAgregarNuevoProducto_Click(object sender, EventArgs e)
        {
            if(new MenuAgregarNuevoProducto().ShowDialog() == DialogResult.OK)
            {
                ActualizarTxbStock();
            }
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if(new MenuCambiarCantidad(true).ShowDialog() == DialogResult.OK)
            {
                ActualizarTxbStock();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoverProd_Click(object sender, EventArgs e)
        {
            
            if(new MenuRemoverProducto().ShowDialog() != DialogResult.Cancel)
            {
                ActualizarTxbStock();
            }
        }

        private void btnQuitarStock_Click(object sender, EventArgs e)
        {
            if(new MenuCambiarCantidad(false).ShowDialog() != DialogResult.Cancel)
            {
                ActualizarTxbStock();
            }
        }

        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
            if (new MenuModificarPrecio().ShowDialog() != DialogResult.Cancel)
            {
                ActualizarTxbStock();
            }
        }

        /// <summary>
        /// Actualiza el texto de la textbox con la informacion de los productos en el stock
        /// </summary>
        private void ActualizarTxbStock()
        {
            Serializador serializador = new Serializador();
            productosList = serializador.Leer();
            txbStock.Text=String.Empty;
            productosList.OfType<Elaborado>().ToList().ForEach(item => txbStock.Text += item.Mostrar(false));
            productosList.OfType<Grano>().ToList().ForEach(item => txbStock.Text += item.Mostrar(false));
            productosList.OfType<Merchandise>().ToList().ForEach(item => txbStock.Text += item.Mostrar(false));
        }

        private void MenuStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
