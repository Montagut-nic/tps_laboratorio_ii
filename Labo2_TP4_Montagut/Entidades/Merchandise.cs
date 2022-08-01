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

        /// <summary>
        /// constructor publico de la clase Merchandise, su generic T es ETipoPrenda
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="tipo"></param>
        /// <param name="talle"></param>
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

        /// <summary>
        /// sobrecarga del metodo ToString, retorna un string para mostrar nombre, cantidad en stock, tipo de prenda y talle del producto mientras se muestra en el MenuVenta
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.Tipo}: {this.Nombre}, talle: {this.Talle}, cantidad (en stock): {this.Cantidad}";
        }

        /// <summary>
        /// retorna un string que muestra la informacion del producto de forma ordenada, recibe un bool para mostrar o no el precio unitario del producto
        /// </summary>
        /// <param name="mostrarPrecioUnitario"></param>
        /// <returns></returns>
        public string Mostrar(bool mostrarPrecioUnitario)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Tipo}: {this.Nombre} talle {this.Talle}");
            sb.AppendLine($"\t\t Cantidad: {this.Cantidad}");
            sb.AppendLine($"\t\t Precio: {this.Precio.ToString("0.00")}");
            if (mostrarPrecioUnitario)
            {
                sb.Append($"\t\t ({this.Cantidad} x {(this.Precio / this.Cantidad).ToString("0.00")})");
            }
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// implementacion del metodo agregar de la interfaz IStockeable, agrega el producto a una lista mientras reduce su cantidad en stock,
        /// si el producto ya estaba en la lista aumenta cantidad y precio del producto de la lista en vez de agregarlo
        /// </summary>
        /// <param name="carritoProductos"></param>
        /// <param name="cantidad"></param>
        /// <param name="descuento"></param>
        /// <exception cref="NoHayCantidadDelProductoException"></exception>
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

        /// <summary>
        /// implementacion del metodo quitar de la interfaz IStockeable, quita una cantidad o remueve por completo un producto de una lista de productos
        /// </summary>
        /// <param name="carritoProductos"></param>
        /// <param name="cantidad"></param>
        /// <exception cref="Exception"></exception>
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
