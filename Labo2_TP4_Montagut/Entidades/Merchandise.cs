using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Merchandise : Producto<Merchandise.ETipoPrenda>
    {
        ETalle talle;

        public Merchandise(string nombre, int cantidad, float precio, ETipoPrenda tipo, ETalle talle) : base(nombre, cantidad, precio, tipo)
        {
            this.talle = talle;
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
            return $"{this.tipo}: {this.nombre}, talle: {this.talle}";
        }

    }
}
