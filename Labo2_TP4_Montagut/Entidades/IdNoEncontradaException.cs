using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IdNoEncontradaException : Exception
    {
        /// <summary>
        /// constructor de la exception IdNoEncontradaException, recibe un id que no se pudo asociar con un cliente activo
        /// </summary>
        /// <param name="id"></param>
        public IdNoEncontradaException(int id) : base($"No se ha encontrado un cliente activo con el id ingresado: {id}") 
        {
        }
    }
}
