using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoHayCantidadDelProductoException : Exception
    {
        /// <summary>
        /// constructor de NoHayCantidadDelProductoException que sirve para granos, recibe solo nombre
        /// </summary>
        /// <param name="nombre"></param>
        public NoHayCantidadDelProductoException(string nombre) : base($"no hay esa cantidad de {nombre} en stock")
        {
        }

        /// <summary>
        /// constructor de NoHayCantidadDelProductoException que sirve para productos elaborados, recibe nombre y marca
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        public NoHayCantidadDelProductoException(string nombre, string marca) : base($"no hay esa cantidad de {nombre} marca {marca} en stock")
        {
        }

        /// <summary>
        /// constructor de NoHayCantidadDelProductoException que sirve para merchandise, tipo de prenda, nombre y talle
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nombre"></param>
        /// <param name="talle"></param>
        public NoHayCantidadDelProductoException(string tipo, string nombre, string talle) : base($"no hay esa cantidad de {tipo}: {nombre} talle {talle} en stock")
        {
        }
    }
}
