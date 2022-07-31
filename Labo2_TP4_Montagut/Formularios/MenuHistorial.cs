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
    public partial class MenuHistorial : Form
    {
        public MenuHistorial()
        {
            InitializeComponent();
            try 
            { 
                txbHistorialDeVentas.Text = LogicaNegocio.LeerHistorialDeVentas();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
