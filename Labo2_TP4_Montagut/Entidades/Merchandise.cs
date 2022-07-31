using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Merchandise : Producto<Merchandise.ETipoPrenda>, IStockeable
    {
        private ETalle talle;

        public ETalle Talle { get => talle; set => talle = value; }

        public Merchandise(string nombre, int cantidad, float precio, ETipoPrenda tipo, ETalle talle) : base(nombre, cantidad, precio, tipo)
        {
            this.Talle = talle;
        }

        public enum ETipoPrenda
        {
            Remera,
            Buzo,
            Campera
        }
        public enum ETalle
        {
            Unico,
            S,
            M,
            L
        }

        public override string ToString()
        {
            return $"{this.Tipo}: {this.Nombre}, talle: {this.Talle}, cantidad (en stock): {this.Cantidad}";
        }

        public string Mostrar(bool mostrarPrecioUnitario)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Tipo}: {this.Nombre} talle {this.Talle}");
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
                throw new NoHayCantidadDelProductoException(Tipo.ToString(),Nombre,Talle.ToString());
            }
            float precio=(Precio*cantidad) - (Precio*descuento);
            Cantidad -= cantidad;
            Merchandise producto = carritoProductos.OfType<Merchandise>().ToList().Find(item => item.Nombre == Nombre && item.Tipo == Tipo && item.Talle == Talle);
            if(producto is not null)
            {
                producto.Cantidad += cantidad;
                producto.Precio += precio;
            }
            else
            {
                carritoProductos.Add(new Merchandise(Nombre,cantidad,precio,Tipo,Talle));
            }
        }

        public void Quitar(ArrayList carritoProductos, int cantidad)
        {
            Merchandise producto = carritoProductos.OfType<Merchandise>().ToList().Find(item => item.Nombre == Nombre && item.Tipo == Tipo && item.Talle == Talle);
            if(producto is not null)
            {
                if(producto.Cantidad <= cantidad)
                {
                    Cantidad+=producto.Cantidad;
                    carritoProductos.Remove(producto);
                }
                else
                {
                    Cantidad += cantidad;
                    producto.Precio -= cantidad*(producto.Precio/producto.Cantidad);
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
