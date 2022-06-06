using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IdNoEncontradaException : Exception
    {
        public IdNoEncontradaException(int id) : base($"No se ha encontrado el id ingresado: {id}") 
        {
        }
    }
}
