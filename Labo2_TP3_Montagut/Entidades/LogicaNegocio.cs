using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class LogicaNegocio
    {
        public static Dictionary<int, Cliente> clientesMiembros;

        /// <summary>
        /// Constructor estatico de LogicaNegocio, carga la coleccion de clientes
        /// </summary>
        static LogicaNegocio()
        {
            clientesMiembros = new Dictionary<int, Cliente>();
            CargarClientes();
        }

       /// <summary>
       /// Carga la coleccion de clientes desde un archivo .json, si no existe lo crea
       /// </summary>
        private static void CargarClientes()
        {

            
        }

        public static Cliente BuscarClientePorId(string stringId)
        {
            Cliente cliente;
            int id;

            if(string.IsNullOrWhiteSpace(stringId) || !int.TryParse(stringId.Trim(), out id) || id <= 0 )
            {
                throw new FormatException("No se ha ingresado un id valido");
            }

            if(!clientesMiembros.TryGetValue(id, out cliente))
            {
                throw new IdNoEncontradaException(id);
            }

            return cliente;
        }
    }
}
