using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoHayCantidadDelProductoException : Exception
    {
        public NoHayCantidadDelProductoException(string nombre) : base($"no hay esa cantidad de {nombre} en stock")
        {
        }
        public NoHayCantidadDelProductoException(string nombre, string marca) : base($"no hay esa cantidad de {nombre} marca {marca} en stock")
        {
        }
        public NoHayCantidadDelProductoException(string tipo, string nombre, string talle) : base($"no hay esa cantidad de {tipo}: {nombre} talle {talle} en stock")
        {
        }
    }
}
