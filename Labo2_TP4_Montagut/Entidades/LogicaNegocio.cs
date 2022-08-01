using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public static class LogicaNegocio 
    {
        private static Dictionary<int, Cliente> clientesMiembros;

        /// <summary>
        /// Constructor estatico de LogicaNegocio, carga la coleccion de clientes
        /// </summary>
        static LogicaNegocio()
        {
            clientesMiembros = new Dictionary<int, Cliente>();
            CargarClientes();
        }

       /// <summary>
       /// Carga una lista de clientes a partir de la base de datos, luego agrega los clientes a un dictionary de clientes 
       /// </summary>
        private static void CargarClientes()
        {

            List<Cliente> clientes = ManejadorBD.Leer();
            clientes.ForEach(cliente => clientesMiembros.Add(cliente.Id, cliente));
        }

        /// <summary>
        /// Retorna un cliente activo a partir del id proporcionado, es buscado dentro del dictionary de clientes 
        /// </summary>
        /// <param name="stringId"></param>
        /// <returns></returns>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="IdNoEncontradaException"></exception>
        public static Cliente BuscarClienteActivoPorId(string stringId)
        {
            Cliente cliente;
            int id;

            if(string.IsNullOrWhiteSpace(stringId) || !int.TryParse(stringId.Trim(), out id) || id <= 0 )
            {
                throw new FormatException("No se ha ingresado un id valido");
            }

            if(!clientesMiembros.TryGetValue(id, out cliente) || cliente.Activo==false)
            {
                throw new IdNoEncontradaException(id);
            }

            return cliente;
        }

        /// <summary>
        /// agrega un cliente al dictionary o toma el lugar de un cliente inactivo, luego lo agrega o modifica en la base de datos de clientes
        /// </summary>
        /// <param name="cliente"></param>
        public static void AgregarCliente (Cliente cliente, DelegadoActualizarMensaje delegado)
        {
            bool modificoClienteInactivo = false;
            try 
            { 
                foreach (Cliente miembro in clientesMiembros.Values)
                {
                    if (miembro.Activo)
                    {
                        if(miembro.Id == cliente.Id)
                        {
                            delegado($"Ya existe un cliente activo registrado con el ID/DNI {cliente.Id}");
                        }
                        if(miembro.Mail == cliente.Mail)
                        {
                            delegado($"Ya existe un cliente activo registrado con el mail {cliente.Mail}");
                        }
                    }
                    else
                    {
                        try { 
                            if (miembro.Id == cliente.Id)
                            {
                                miembro.Activo = true;
                                miembro.Nombre = cliente.Nombre;
                                miembro.Apellido = cliente.Apellido;
                                miembro.Mail = cliente.Mail;
                                modificoClienteInactivo = true;
                                ManejadorBD.ModificarCliente(miembro.Nombre, miembro.Apellido, miembro.Mail.Address, miembro.Id,miembro.Activo);
                                break;
                            }
                        }catch (Exception ex)
                        {
                            delegado($"Ocurrio un error con los parametros del cliente ingresado: {ex.Message}");
                        }
                    }
                }
                if (!modificoClienteInactivo)
                {
                    clientesMiembros.Add(cliente.Id, cliente);
                    ManejadorBD.AgregarCliente(cliente.Nombre, cliente.Apellido, cliente.Mail.Address, cliente.Id,cliente.Activo);
                }
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
