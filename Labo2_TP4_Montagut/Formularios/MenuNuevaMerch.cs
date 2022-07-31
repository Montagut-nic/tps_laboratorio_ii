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
    public partial class MenuNuevaMerch : Form
    {
        ArrayList listaProductos;

        public MenuNuevaMerch()
        {
            InitializeComponent();
            listaProductos = LogicaNegocio.CargarProductos();
            lsbTipoPrenda.Items.Add(Merchandise.ETipoPrenda.Remera);
            lsbTipoPrenda.Items.Add(Merchandise.ETipoPrenda.Buzo);
            lsbTipoPrenda.Items.Add(Merchandise.ETipoPrenda.Campera);
            lsbTalle.Items.Add(Merchandise.ETalle.Unico);
            lsbTalle.Items.Add(Merchandise.ETalle.S);
            lsbTalle.Items.Add(Merchandise.ETalle.M);
            lsbTalle.Items.Add(Merchandise.ETalle.L);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try 
            { 
                if(listaProductos is not null && !String.IsNullOrWhiteSpace(txbNombre.Text) && nudCantidad.Value>0 && nudPrecio.Value>0 && lsbTalle.SelectedItem is not null && lsbTipoPrenda.SelectedItem is not null) 
                { 
                    Merchandise merchNueva = new Merchandise(txbNombre.Text, (int)nudCantidad.Value, (float)nudPrecio.Value, (Merchandise.ETipoPrenda)lsbTipoPrenda.SelectedItem, (Merchandise.ETalle)lsbTalle.SelectedItem);
                    if (listaProductos.OfType<Merchandise>().ToList().Any(item => item.Nombre == merchNueva.Nombre && item.Talle==merchNueva.Talle && item.Tipo==merchNueva.Tipo)) 
                    {
                        throw new Exception("El producto ya se encuentra en el stock");
                    }
                    else
                    {
                        listaProductos.Add(merchNueva);
                        LogicaNegocio.GuardarProductos(listaProductos);
                        MessageBox.Show($"{merchNueva.Nombre} fue agregada al stock exitosamente");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                else
                {
                    throw new Exception("Valide los datos antes de presionar confirmar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
