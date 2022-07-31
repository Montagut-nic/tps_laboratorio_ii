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
    public partial class MenuAgregarNuevoProducto : Form
    {
        public MenuAgregarNuevoProducto()
        {
            InitializeComponent();
        }

        private void btnAgregarGrano_Click(object sender, EventArgs e)
        {
            this.Close();
            if(new MenuNuevoGrano().ShowDialog() != DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAgregarMerch_Click(object sender, EventArgs e)
        {
            this.Close();
            if(new MenuNuevaMerch().ShowDialog() != DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAgregarProdElab_Click(object sender, EventArgs e)
        {
            this.Close();
            if(new MenuNuevoProdElaborado().ShowDialog() != DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
