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
    public partial class MenuVenta : Form
    {
        string clienteComprador;
        ArrayList productos;
        Carrito compra;

        public MenuVenta()
        {
            clienteComprador = String.Empty;
            compra = new Carrito();
            InitializeComponent();
            productos = LogicaNegocio.CargarProductos();
            ActualizarListboxProductos();
            ActualizarLabelDescuento();



        }

        public MenuVenta(Cliente cliente) : this()
        {
            this.clienteComprador = cliente.Nombre+" "+cliente.Apellido;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarListboxProductos()
        {
            lsbProductos.DataSource = null;
            lsbProductos.DataSource = productos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarLabelDescuento()
        {
            DateTime finOferta;
            int anio=DateTime.Today.Year;
            int mes=DateTime.Today.Month;

            if(compra.SiguienteDescuento == 1)
            {
                if(DateTime.Today.Month == 12)
                {
                    anio+=1;
                }
                mes = DateTime.Today.AddMonths(1).Month;
                
            }
            finOferta = new DateTime(anio,mes, compra.SiguienteDescuento, 0, 0, 0, 0);
            TimeSpan ts = finOferta - DateTime.Now;
            //TODO: agregar tiempo restande del descuento
            lblDescuento.Text = compra.MostrarDescuento() + $" y quedan {ts.ToString(@"dd\ hh\:mm\:ss")} para aprovechar esta oferta";

        }
    }
}
