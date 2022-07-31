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
    public partial class MenuNuevoGrano : Form
    {
        ArrayList listaProductos;

        public MenuNuevoGrano()
        {
            InitializeComponent();
            listaProductos = LogicaNegocio.CargarProductos();
            lsbTipo.Items.Add(Grano.ETipoGrano.Avena);
            lsbTipo.Items.Add(Grano.ETipoGrano.Lenteja);
            lsbTipo.Items.Add(Grano.ETipoGrano.Garbanzo);
            lsbTipo.Items.Add(Grano.ETipoGrano.Poroto);
            lsbTipo.Items.Add(Grano.ETipoGrano.Arroz);
            lsbTipo.Items.Add(Grano.ETipoGrano.Chia);
            lsbTipo.Items.Add(Grano.ETipoGrano.MixSemillas);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaProductos is not null && !String.IsNullOrWhiteSpace(txbNombre.Text) && nudCantidad.Value > 0 && nudPrecio.Value > 0 && lsbTipo.SelectedItem is not null)
                {
                    Grano granoNuevo = new Grano(txbNombre.Text, (int)nudCantidad.Value, (float)nudPrecio.Value, (Grano.ETipoGrano)lsbTipo.SelectedItem);
                    if (listaProductos.OfType<Grano>().ToList().Any(item => item.Nombre == granoNuevo.Nombre && item.Tipo == granoNuevo.Tipo))
                    {
                        throw new Exception("El producto ya se encuentra en el stock");
                    }
                    else
                    {
                        listaProductos.Add(granoNuevo);
                        LogicaNegocio.GuardarProductos(listaProductos);
                        MessageBox.Show($"{granoNuevo.Nombre} fue agregado al stock exitosamente");
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
