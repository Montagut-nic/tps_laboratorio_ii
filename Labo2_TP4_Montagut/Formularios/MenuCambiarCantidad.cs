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
    public partial class MenuCambiarCantidad : Form
    {
        ArrayList listaProductos;
        bool suma;
        public MenuCambiarCantidad(bool sumar)
        {
            InitializeComponent();
            listaProductos = LogicaNegocio.CargarProductos();
            lsbProductos.DataSource = listaProductos;
            if (sumar)
            {
                this.Text = "Menu - Sumar Cantidad";
            }
            else
            {
                this.Text = "Menu - Restar Cantidad";
            }
            suma = sumar;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try { 
                if (listaProductos is not null && lsbProductos.SelectedItem is not null && nudCantidad.Value>0)
                {
                    switch (lsbProductos.SelectedItem.GetType().Name)
                    {
                        case "Merchandise":
                            Merchandise prodMerch = (Merchandise)lsbProductos.SelectedItem;
                            if(prodMerch is not null)
                            {
                                if (suma)
                                {
                                    prodMerch.Cantidad += (int)nudCantidad.Value;
                                }
                                else if((int)nudCantidad.Value <= prodMerch.Cantidad) 
                                {
                                    prodMerch.Cantidad-=(int)nudCantidad.Value;
                                }
                                else
                                {
                                    throw new NoHayCantidadDelProductoException(prodMerch.Tipo.ToString(), prodMerch.Nombre, prodMerch.Talle.ToString());
                                }
                            }
                            break;
                        case "Grano":
                            Grano prodGrano = (Grano)lsbProductos.SelectedItem;
                            if (prodGrano is not null)
                            {
                                if (suma)
                                {
                                    prodGrano.Cantidad += (int)nudCantidad.Value;
                                }
                                else if ((int)nudCantidad.Value <= prodGrano.Cantidad)
                                {
                                    prodGrano.Cantidad -= (int)nudCantidad.Value;
                                }
                                else
                                {
                                    throw new NoHayCantidadDelProductoException(prodGrano.Nombre);
                                }
                            }
                            break;
                        case "Elaborado":
                            Elaborado prodElab = (Elaborado)lsbProductos.SelectedItem;
                            if (prodElab is not null)
                            {
                                if (suma)
                                {
                                    prodElab.Cantidad += (int)nudCantidad.Value;
                                }
                                else if ((int)nudCantidad.Value <= prodElab.Cantidad)
                                {
                                    prodElab.Cantidad -= (int)nudCantidad.Value;
                                }
                                else
                                {
                                    throw new NoHayCantidadDelProductoException(prodElab.Nombre, prodElab.Marca.ToString());
                                }
                            }
                            break;
                    }
                
                    LogicaNegocio.GuardarProductos(listaProductos);
                    MessageBox.Show("Se ha modificado el producto exitosamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
