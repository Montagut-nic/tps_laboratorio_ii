using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        private ArrayList listaProductos;
        private float descuento;
        private float total;
        private Enum tipoDesc;
        private Elaborado.EMarca marcaDesc;
        private bool requiereMarca;
        private int siguienteDescuento;
        private bool aplicaDesc;
        public event DelegadoActualizarLabel ActualizarTiempoDescuento;
        private Task task;
        public Carrito(bool desc)
        {
            listaProductos = new ArrayList();
            requiereMarca = false;
            aplicaDesc = desc; 
        }

        public void iniciarTask()
        {
            task = new Task(() =>
            {
                while (ActualizarTiempoDescuento is not null)
                {
                    ActualizarTiempoDescuento.Invoke();
                }
            });
            task.Start();
        }

        private void AsignarDescuento()
        {
            switch (DateTime.Today.Day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    requiereMarca = true;
                    descuento = 35f / 100;
                    marcaDesc= Elaborado.EMarca.NotCorp;
                    tipoDesc = Elaborado.ETipo.Hamburguesa;
                    siguienteDescuento = 5;
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    descuento = 20f / 100;
                    tipoDesc = Grano.ETipoGrano.Lenteja;
                    siguienteDescuento = 9;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    descuento = 50f / 100;
                    tipoDesc = Merchandise.ETipoPrenda.Remera;
                    siguienteDescuento = 13;
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                    requiereMarca= true;
                    descuento = 15f / 100;
                    tipoDesc = Elaborado.ETipo.Milanesa;
                    marcaDesc = Elaborado.EMarca.Hierbalex;
                    siguienteDescuento = 17;
                    break;
                case 17:
                case 18:
                case 19:
                case 20:
                    descuento = 40f / 100;
                    tipoDesc = Merchandise.ETipoPrenda.Buzo;
                    siguienteDescuento = 21;
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                    requiereMarca = true;
                    descuento = 60f / 100;
                    tipoDesc = Elaborado.ETipo.Leche;
                    marcaDesc = Elaborado.EMarca.NotCorp;
                    siguienteDescuento = 25;
                    break;
                case 25:
                case 26:
                case 27:
                    descuento = 30f / 100;
                    tipoDesc = Grano.ETipoGrano.Garbanzo;
                    siguienteDescuento = 28;
                    break;
                case 28:
                case 29:
                case 30:
                case 31:
                    descuento = 70f / 100;
                    tipoDesc= Grano.ETipoGrano.Avena;
                    siguienteDescuento = 1;
                    break;
            }
        }

        public int SiguienteDescuento { get=>siguienteDescuento; }
        public ArrayList Productos { get => listaProductos; }

        public void AgregarAlCarrito(object prod,int cantidad)
        {
            try
            {
                Merchandise merch= null;
                Grano grano=null;
                Elaborado elab=null;
                switch (prod.GetType().Name)
                {
                    case "Merchandise":
                        merch = (Merchandise)prod;
                        if (aplicaDesc && merch.Tipo.ToString() == tipoDesc.ToString()) { 
                            merch.Agregar(listaProductos, cantidad, descuento);
                        }
                        else
                        {
                            merch.Agregar(listaProductos, cantidad, 0);
                        }
                        break;
                    case "Grano":
                        grano = (Grano)prod;
                        
                        if (aplicaDesc && grano.Tipo.ToString() == tipoDesc.ToString())
                        {
                            grano.Agregar(listaProductos, cantidad, descuento);
                        }
                        else
                        {
                            grano.Agregar(listaProductos, cantidad, 0);
                        }
                        break;
                    case "Elaborado":
                        elab = (Elaborado)prod;
                        if (aplicaDesc && elab.Tipo.ToString() == tipoDesc.ToString() && elab.Marca.ToString() == marcaDesc.ToString())
                        {
                            elab.Agregar(listaProductos, cantidad, descuento);
                        }
                        else
                        {
                            elab.Agregar(listaProductos, cantidad, 0);
                        }
                        break;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void QuitarDelCarrito(object prod, int cantidad)
        {
            try
            { 
                Merchandise merch = null;
                Grano grano = null;
                Elaborado elab = null;
                switch (prod.GetType().Name) 
                {
                    case "Merchandise":
                        merch = (Merchandise)prod;
                        merch.Quitar(listaProductos,cantidad);
                        break;
                    case "Grano":
                        grano = (Grano)prod;
                        grano.Quitar(listaProductos, cantidad);
                        break;
                    case "Elaborado":
                        elab = (Elaborado)prod;
                        elab.Quitar(listaProductos, cantidad);
                        break;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void VaciarCarrito(ArrayList productosArrayList)
        {
            if (Productos.Count != 0 && Productos is not null && productosArrayList is not null)
            {

                List<Merchandise> listaProdMerch = productosArrayList.OfType<Merchandise>().ToList();
                List<Merchandise> listaCarritoMerch = Productos.OfType<Merchandise>().ToList();
                foreach (Merchandise merchandise in listaProdMerch)
                {
                    listaCarritoMerch.ForEach(item => {
                        if (item.Nombre == merchandise.Nombre && item.Tipo == merchandise.Tipo && item.Talle == merchandise.Talle)
                        {
                            QuitarDelCarrito(merchandise, item.Cantidad);
                        }
                    });

                }
                List<Grano> listaProdGrano = productosArrayList.OfType<Grano>().ToList();
                List<Grano> listaCarritoGrano = Productos.OfType<Grano>().ToList();
                foreach (Grano grano in listaProdGrano)
                {
                    listaCarritoGrano.ForEach(item => {
                        if (item.Nombre == grano.Nombre && item.Tipo == grano.Tipo)
                        {
                            QuitarDelCarrito(grano, item.Cantidad);
                        }
                    });

                }
                List<Elaborado> listaProdElab = productosArrayList.OfType<Elaborado>().ToList();
                List<Elaborado> listaCarritoElab = Productos.OfType<Elaborado>().ToList();
                foreach (Elaborado elab in listaProdElab)
                {
                    listaCarritoElab.ForEach(item => {
                        if (item.Nombre == elab.Nombre && item.Tipo == elab.Tipo && item.Marca == elab.Marca)
                        {
                            QuitarDelCarrito(elab, item.Cantidad);
                        }
                    });

                }
            }
        }

        public string MostrarCarrito()
        {
            total = 0;
            StringBuilder sb = new StringBuilder();
            listaProductos.OfType<Elaborado>().ToList().ForEach(item => { sb.Append(item.Mostrar(true));total += item.Precio; });
            listaProductos.OfType<Grano>().ToList().ForEach(item => { sb.Append(item.Mostrar(true)); total += item.Precio; });
            listaProductos.OfType<Merchandise>().ToList().ForEach(item => { sb.Append(item.Mostrar(true)); total += item.Precio; });
            sb.Append($"TOTAL: {total}");
            return sb.ToString();
        }

        public string MostrarDescuento()
        {
            AsignarDescuento();
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hoy hay {Math.Round(descuento*100,0)}% de descuento en {tipoDesc}s");
            if (requiereMarca)
            {
                sb.Append($" marca {marcaDesc}");
            }
            return sb.ToString();
        }

    }
}
