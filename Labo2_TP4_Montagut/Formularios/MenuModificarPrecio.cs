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
    public partial class MenuModificarPrecio : Form
    {
        ArrayList listaProductos;
        public MenuModificarPrecio()
        {
            InitializeComponent();
            listaProductos = LogicaNegocio.CargarProductos();
            lsbProductos.DataSource = listaProductos;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if(lsbProductos.SelectedItem is not null && nudPrecioNuevo.Value > 0 && listaProductos is not null)
                {
                    switch (lsbProductos.SelectedItem.GetType().Name)
                    {
                        case "Merchandise":
                            Merchandise prodMerch = (Merchandise)lsbProductos.SelectedItem;
                            if (prodMerch is not null)
                            {
                                prodMerch.Precio = (float)nudPrecioNuevo.Value;
                            }
                            break;
                        case "Grano":
                            Grano prodGrano = (Grano)lsbProductos.SelectedItem;
                            if (prodGrano is not null)
                            {
                                prodGrano.Precio = (float)nudPrecioNuevo.Value;
                            }
                            break;
                        case "Elaborado":
                            Elaborado prodElab = (Elaborado)lsbProductos.SelectedItem;
                            if (prodElab is not null)
                            {
                                prodElab.Precio = (float)nudPrecioNuevo.Value;
                            }
                            break;
                    }
                    LogicaNegocio.GuardarProductos(listaProductos);
                    MessageBox.Show("Se ha modificado el producto exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
