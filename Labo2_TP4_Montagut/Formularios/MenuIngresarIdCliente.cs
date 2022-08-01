using Entidades;
using System;
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
    public partial class MenuIngresarIdCliente : Form
    {
        private Button btnOrigen;
        private bool flagContinuar;

        /// <summary>
        /// Constructor de MenuIngresarIdCliente
        /// </summary>
        public MenuIngresarIdCliente()
        {
            btnOrigen = new Button();
            flagContinuar = false;
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de MenuIngresarIdCliente, asigna el boton por el que se instancio el formulario como btnOrigen
        /// </summary>
        /// <param name="btnLlamador"></param>
        public MenuIngresarIdCliente(Button btnLlamador) : this()
        {
            btnOrigen = btnLlamador;
        }

        /// <summary>
        /// Evento para buscar el id y generar el menu correspondiente segun el boton de origen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            try
            {
                cliente = LogicaNegocio.BuscarClienteActivoPorId(txbIdDeCliente.Text.Trim());
                flagContinuar = true;
                this.Close();

                if (btnOrigen.Text.Contains("baja"))
                {
                    new MenuBajaModificacionMiembro(cliente).Show();
                }else
                {
                    new MenuVenta(true).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuIngresarIdCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!flagContinuar)
            {
                Application.OpenForms[0].Show();
            }
        }
    }
}
