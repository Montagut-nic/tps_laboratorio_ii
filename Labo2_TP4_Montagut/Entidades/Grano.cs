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

        public override string ToString()
        {
            return $"{this.Tipo}: {this.Nombre}, cantidad (en stock): {this.Cantidad} gramos";
        }

        public string Mostrar(bool mostrarPrecioUnitario)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Tipo}: {this.Nombre}");
            sb.AppendLine($"\t\t Peso: {this.Cantidad} gr / {this.PesoEnKilos} kg");
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
