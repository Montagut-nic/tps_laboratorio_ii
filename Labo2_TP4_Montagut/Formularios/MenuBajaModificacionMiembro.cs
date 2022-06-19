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
    public partial class MenuBajaModificacionMiembro : Form
    {
        Cliente cliente;
        public MenuBajaModificacionMiembro()
        {
            cliente = null;
            InitializeComponent();
        }

        public MenuBajaModificacionMiembro(Cliente miembro) : this()
        {
            cliente = miembro;
            txbApellido.Text = miembro.Apellido;
            txbEmail.Text = miembro.Mail.Address;
            txbNombre.Text = miembro.Nombre;
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.CambiarInformacion(txbEmail.Text, txbNombre.Text, txbApellido.Text);
                MessageBox.Show("Se han realizado los cambios satisfactoriamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            cliente.Activo = false;
            cliente.Mail = null;
            MessageBox.Show($"Se ha dado de baja al cliente con el id {cliente.Id}");
            this.Close();
        }

        private void MenuBajaModificacionMiembro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
