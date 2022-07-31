using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Elaborado : Producto<Elaborado.ETipo>, IStockeable
    {
        private EMarca marca;

        public EMarca Marca { get => marca; set => marca = value; }

        public Elaborado(string nombre, int cantidad, float precio, ETipo tipo, EMarca marca) : base(nombre,cantidad,precio,tipo)
        {
            this.Marca = marca;
        }
        public enum ETipo
        {
            Milanesa,
            Hamburguesa,
            Leche
        }

        public enum EMarca
        {
            Hierbalex,
            NotCorp,
            GranjaDeLaLuna
        }

        public override string ToString()
        {
            return $"{this.Nombre}, {this.Tipo} marca {this.Marca}, cantidad (en stock): {this.Cantidad}"; 
        }

        public string Mostrar(bool mostrarPrecioUnitario)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Tipo}: {this.Nombre} marca {this.Marca}");
            sb.AppendLine($"\t\t Cantidad: {this.Cantidad}");
            sb.AppendLine($"\t\t Precio: {this.Precio}");
            if (mostrarPrecioUnitario) 
            { 
                sb.Append($" ({this.Cantidad} x {(this.Precio / this.Cantidad).ToString("0.00")})");
            }
            sb.AppendLine();
            return sb.ToString();
        }

        public void Agregar(ArrayList carritoProductos, int cantidad, float descuento)
        {
            if (cantidad > Cantidad)
            {
                throw new NoHayCantidadDelProductoException( Nombre, Marca.ToString());
            }
            float precio = (Precio * cantidad) - (Precio * descuento);
            Cantidad -= cantidad;
            Elaborado producto = carritoProductos.OfType<Elaborado>().ToList().Find(item => item.Nombre == Nombre && item.Tipo == Tipo && item.Marca == Marca);
            if (producto is not null)
            {
                producto.Cantidad += cantidad;
                producto.Precio += precio;
            }
            else
            {
                carritoProductos.Add(new Elaborado(Nombre, cantidad, precio, Tipo, Marca));
            }
        }

        public void Quitar(ArrayList carritoProductos, int cantidad)
        {
            Elaborado producto = carritoProductos.OfType<Elaborado>().ToList().Find(item => item.Nombre == Nombre && item.Tipo == Tipo && item.Marca == Marca);
            if (producto is not null)
            {
                if (producto.Cantidad <= cantidad)
                {
                    Cantidad += producto.Cantidad;
                    carritoProductos.Remove(producto);
                }
                else
                {
                    Cantidad += cantidad;
                    producto.Precio -= cantidad * (producto.Precio / producto.Cantidad);
                    producto.Cantidad -= cantidad;
                }
            }
            else
            {
                throw new Exception($"{Nombre} no se encuenta en el carrito");
            }
        }
    }
}
