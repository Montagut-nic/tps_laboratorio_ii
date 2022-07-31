using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class MenuVenta : Form
    {
        ArrayList productos;
        Carrito compra;
        
        

        public MenuVenta(bool esCliente)
        {
            InitializeComponent();
            productos = LogicaNegocio.CargarProductos();
            compra = new Carrito(esCliente);
            ActualizarListboxProductos();
            compra.ActualizarTiempoDescuento += ActualizarLabelDescuento;
            compra.ActualizarTiempoDescuento += ActualizarLabelHora;
            compra.iniciarTask();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                compra.QuitarDelCarrito(productos[lsbProductos.SelectedIndex], (int)nudCantidad.Value);
                ActualizarTxbTicket();
                ActualizarListboxProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListboxProductos()
        {
            lsbProductos.DataSource = null;
            lsbProductos.DataSource = productos;
        }

        private void ActualizarTxbTicket()
        {
            txbTicket.Text = compra.MostrarCarrito();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try 
            { 
                
                compra.AgregarAlCarrito(productos[lsbProductos.SelectedIndex],(int)nudCantidad.Value);
                ActualizarTxbTicket();
                ActualizarListboxProductos();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ActualizarLabelDescuento()
        {
            if (lblDescuento.InvokeRequired)
            {
                DelegadoActualizarLabel actualizarLabel = ActualizarLabelDescuento;
                lblDescuento.Invoke(actualizarLabel);
            }
            else { 
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
                lblDescuento.Text = compra.MostrarDescuento() + $" para los clientes del club sano y quedan {ts.ToString("dd' dia/s 'hh' hora/s 'mm' minuto/s 'ss' segundo/s'")} para aprovechar esta oferta";
            }
        }

        private void ActualizarLabelHora()
        {
            if (lblHora.InvokeRequired)
            {
                DelegadoActualizarLabel actualizarLabel = ActualizarLabelHora;
                lblDescuento.Invoke(actualizarLabel);
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            }
                
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            LogicaNegocio.GuardarHistorialDeVentas(txbTicket.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            compra.VaciarCarrito(productos);
            this.Close();
        }

        private void MenuVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
           
           LogicaNegocio.GuardarProductos(productos);
           Application.OpenForms[0].Show();
        }

        
    }
}
