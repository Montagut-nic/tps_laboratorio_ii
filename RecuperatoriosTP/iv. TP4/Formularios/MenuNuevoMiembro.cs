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
    public partial class MenuNuevoMiembro : Form
    {
        bool flagContinuar;
        public MenuNuevoMiembro()
        {
            InitializeComponent();
            flagContinuar = false;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try 
            { 
                LogicaNegocio.AgregarCliente(new Cliente(txbMail.Text,txbNombre.Text,txbApellido.Text,txbIdDni.Text), ActualizarLabelError);
                flagContinuar = true;
                this.Close();
                new MenuVenta(true).Show();
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

        private void MenuNuevoMiembro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!flagContinuar)
            {
                Application.OpenForms[0].Show();
            }
            
        }

        /// <summary>
        /// actualiza el texto del label con el string recibido
        /// </summary>
        /// <param name="str"></param>
        private void ActualizarLabelError(string str)
        {
            lblError.Text = str;
        }
    }
}
