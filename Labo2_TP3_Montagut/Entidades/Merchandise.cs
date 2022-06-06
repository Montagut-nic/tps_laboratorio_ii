using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Merchandise : Producto<Merchandise.ETipo>
    {
        public enum ETipo
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
    }
}
