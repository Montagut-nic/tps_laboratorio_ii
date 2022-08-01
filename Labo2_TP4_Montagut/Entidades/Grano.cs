using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grano : Producto <Grano.ETipoGrano>, IStockeable
    {
        /// <summary>
        /// constructor publico de la clase Grano, su generic T es ETipoGrano
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="tipo"></param>
        public Grano(string nombre, int cantidad, float precio, ETipoGrano tipo) : base(nombre, cantidad, precio, tipo)
        {
        }

        public float PesoEnKilos { get => Cantidad/1000f; }
        
        
        public enum ETipoGrano
        {
            Lenteja,
            Arroz,
            Avena,
            Chia,
            Garbanzo,
            Poroto,
            MixSemillas
        }

        /// <summary>
        /// sobrecarga del metodo ToString, retorna un string para mostrar nombre y cantidad en stock del producto mientras se muestra en el MenuVenta
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.Tipo}: {this.Nombre}, cantidad (en stock): {this.Cantidad} gramos";
        }

        /// <summary>
        /// retorna un string que muestra la informacion del grano de forma ordenada, recibe un bool para mostrar o no el precio unitario del producto
        /// </summary>
        /// <param name="mostrarPrecioUnitario"></param>
        /// <returns></returns>
        public string Mostrar(bool mostrarPrecioUnitario)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Tipo}: {this.Nombre}");
            sb.AppendLine($"\t\t Peso: {this.Cantidad} gr / {this.PesoEnKilos} kg");
            sb.AppendLine($"\t\t Precio: {this.Precio.ToString("0.00")}");
            if (mostrarPrecioUnitario)
            {
                sb.AppendLine($"\t\t ({this.Cantidad} x {(this.Precio / this.Cantidad).ToString("0.00")})");
            }
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// implementacion del metodo agregar de la interfaz IStockeable, agrega el grano a una lista mientras reduce su cantidad en stock,
        /// si el grano ya estaba en la lista aumenta cantidad y precio del grano de la lista en vez de agregarlo
        /// </summary>
        /// <param name="carritoProductos"></param>
        /// <param name="cantidad"></param>
        /// <param name="descuento"></param>
        /// <exception cref="NoHayCantidadDelProductoException"></exception>
        public void Agregar(ArrayList carritoProductos, int cantidad, float descuento)
        {
            if (cantidad > Cantidad)
            {
                throw new NoHayCantidadDelProductoException(Nombre);
            }
            float precio = (Precio * cantidad) - (Precio * descuento);
            Cantidad -= cantidad;
            Grano producto = carritoProductos.OfType<Grano>().ToList().Find(item => item.Nombre == Nombre && item.Tipo == Tipo);
            if (producto is not null)
            {
                producto.Cantidad += cantidad;
                producto.Precio += precio;
            }
            else
            {
                carritoProductos.Add(new Grano(Nombre, cantidad, precio, Tipo));
            }
        }

        /// <summary>
        /// implementacion del metodo quitar de la interfaz IStockeable, quita una cantidad o remueve por completo un grano de una lista de productos
        /// </summary>
        /// <param name="carritoProductos"></param>
        /// <param name="cantidad"></param>
        /// <exception cref="Exception"></exception>
        public void Quitar(ArrayList carritoProductos, int cantidad)
        {
            Grano producto = carritoProductos.OfType<Grano>().ToList().Find(item => item.Nombre == Nombre && item.Tipo == Tipo);
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
