using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Elaborado : Producto<Elaborado.ETipo>
    {
        EMarca marca;
        public Elaborado(string nombre, int cantidad, float precio, ETipo tipo, EMarca marca) : base(nombre,cantidad,precio,tipo)
        {
            this.marca = marca;
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
            return $"{this.nombre}, {this.tipo} marca {this.marca}"; 
        }
    }
}
