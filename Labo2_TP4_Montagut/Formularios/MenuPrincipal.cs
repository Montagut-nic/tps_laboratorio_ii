using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para navegar los menues de la aplicacion en el menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (((Button)sender).Name)
            {
                case "btnStock":
                    new MenuStock().Show();
                    break;
                case "btnNuevaVenta":
                    if(MessageBox.Show("Es cliente miembro del club de descuentos Club Sano?","Ya es miembro?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        new MenuIngresarIdCliente((Button)sender).ShowDialog();
                    }else if(MessageBox.Show("Desea unirse al club de descuentos Club Sano?","Desea unirse?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        new MenuNuevoMiembro().Show();
                    }else
                    {
                        new MenuVenta().Show();
                    }
                    break;
                case "btnHistorial":
                    new MenuHistorial().Show();
                    break;
                case "btnBajaModificacionMiembro":
                    new MenuIngresarIdCliente((Button)sender).ShowDialog();
                    break;
            }
            
        } 
    }
}
