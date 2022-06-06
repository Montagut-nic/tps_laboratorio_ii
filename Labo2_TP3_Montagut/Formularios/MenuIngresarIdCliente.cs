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

        /// <summary>
        /// Constructor de MenuIngresarIdCliente
        /// </summary>
        public MenuIngresarIdCliente()
        {
            btnOrigen = new Button();
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de MenuIngresarIdCliente 
        /// </summary>
        /// <param name="btnLlamador"></param>
        public MenuIngresarIdCliente(Button btnLlamador) : this()
        {
            btnOrigen = btnLlamador;
        }

        /// <summary>
        /// Evento para buscar el id y generar el menu correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaNegocio.BuscarClientePorId(txbIdDeCliente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
