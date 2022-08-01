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
    public partial class MenuNuevoProdElaborado : Form
    {
        ArrayList listaProductos;
        public MenuNuevoProdElaborado()
        {
            InitializeComponent();
            Serializador serializador = new Serializador();
            listaProductos = serializador.Leer();
            lsbMarca.Items.Add(Elaborado.EMarca.NotCorp);
            lsbMarca.Items.Add(Elaborado.EMarca.GranjaDeLaLuna);
            lsbMarca.Items.Add(Elaborado.EMarca.Hierbalex);
            lsbTipoProdElaborado.Items.Add(Elaborado.ETipo.Hamburguesa);
            lsbTipoProdElaborado.Items.Add(Elaborado.ETipo.Milanesa);
            lsbTipoProdElaborado.Items.Add(Elaborado.ETipo.Leche);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaProductos is not null && !String.IsNullOrWhiteSpace(txbNombre.Text) && nudCantidad.Value > 0 && nudPrecio.Value > 0 && lsbTipoProdElaborado.SelectedItem is not null && lsbMarca.SelectedItem is not null)
                {
                    Elaborado prodElaboradoNuevo = new Elaborado(txbNombre.Text, (int)nudCantidad.Value, (float)nudPrecio.Value, (Elaborado.ETipo)lsbTipoProdElaborado.SelectedItem, (Elaborado.EMarca)lsbMarca.SelectedItem);
                    if (listaProductos.OfType<Elaborado>().ToList().Any(item => item.Nombre == prodElaboradoNuevo.Nombre && item.Tipo == prodElaboradoNuevo.Tipo && item.Marca==prodElaboradoNuevo.Marca))
                    {
                        throw new Exception("El producto ya se encuentra en el stock");
                    }
                    else
                    {
                        listaProductos.Add(prodElaboradoNuevo);
                        Serializador serializador = new Serializador();
                        serializador.Escribir(listaProductos);
                        MessageBox.Show($"{prodElaboradoNuevo.Nombre} fue agregado al stock exitosamente");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}
