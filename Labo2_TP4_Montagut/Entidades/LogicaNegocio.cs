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
        private static string path;
        public static int ultimoIdProducto;


        /// <summary>
        /// Constructor estatico de LogicaNegocio, carga la coleccion de clientes
        /// </summary>
        static LogicaNegocio()
        {
            ultimoIdProducto = 0;
            clientesMiembros = new Dictionary<int, Cliente>();
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\ArchivosTPFinal\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            CargarClientes();
        }

       /// <summary>
       /// Carga la coleccion de clientes desde una base de datos, 
       /// </summary>
        private static void CargarClientes()
        {
            //TODO: cambiar por lectura .json
            clientesMiembros.Add(1, new Cliente("rita@gmail.com","rita","montag","1"));
            clientesMiembros.Add(2, new Cliente("nico@gmail.com", "nico", "montag", "2"));
        }

        /// <summary>
        /// Devuelve un coleccion de productos desde un archivo .json, si existe el archivo, sino devuelve una coleccion vacia
        /// </summary>
        public static ArrayList CargarProductos() 
        {
            string archivo = string.Empty;
            string[] registroRecuperado;
            StringBuilder sb= new StringBuilder();
            ArrayList listaProd = new ArrayList();
            if (Directory.Exists(path)) 
            {
                string[] archivosEnElPath = Directory.GetFiles(path);
                foreach (string pathArchivo in archivosEnElPath)
                {
                    if (pathArchivo.Contains("productos") && pathArchivo.Contains(".json"))
                    {
                        archivo = pathArchivo;
                        break;
                    }
                }
                if (!string.IsNullOrWhiteSpace(archivo))
                {
                    registroRecuperado = File.ReadAllLines(archivo);
                    foreach (string line in registroRecuperado) 
                    {
                        sb.Append(line);
                        if (line.EndsWith('}') )
                        {
                            if (sb.ToString().Contains("Marca"))
                            {
                                Elaborado prod = JsonSerializer.Deserialize<Elaborado>(sb.ToString());
                                listaProd.Add(prod);
                            }
                            else if (sb.ToString().Contains("Talle"))
                            {
                                Merchandise prod = JsonSerializer.Deserialize<Merchandise>(sb.ToString());
                                listaProd.Add(prod);
                            }
                            else
                            {
                                Grano prod = JsonSerializer.Deserialize<Grano>(sb.ToString());
                                listaProd.Add(prod);
                            }
                            sb.Clear();
                        }
                    }
                }
            }
            return listaProd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string LeerHistorialDeVentas()
        {
            string archivo = string.Empty; 
            string registroRecuperado = string.Empty;
            try 
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string pathArchivo in archivosEnElPath)
                    {
                        if (pathArchivo.Contains(DateTime.Today.ToString("MM-yyyy")) && pathArchivo.Contains(".txt") )
                        {
                            archivo = pathArchivo;
                            break;
                        }
                    }

                    if (!string.IsNullOrEmpty(archivo))
                    {
                        registroRecuperado = File.ReadAllText(archivo);
                    }
                }
                return registroRecuperado;
                
            }catch  (Exception e)
            {
                throw new Exception($"Error en el archivo del {DateTime.Today.ToString("MM - yyyy")} ubicado en {path}", e);
            }
        }

        public static void GuardarHistorialDeVentas(string ticket)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(path+"Historial-De-Ventas-"+DateTime.Today.ToString("MM-yyyy")+".txt",true);
                ticket.Split('\n').ToList().ForEach(x => streamWriter.WriteLine(x));
            }catch (Exception)
            {
                throw;
            }
            finally
            {
                streamWriter.Close();
                streamWriter.Dispose();
            }
        }

        public static void GuardarProductos(ArrayList arrayList)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            string jsonString=String.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (object obj in arrayList)
            {
                sb.AppendLine(JsonSerializer.Serialize(obj,opciones));
                jsonString=sb.ToString();
            }
            File.WriteAllText(path+"productos.json", jsonString);
        }

        /// <summary>
        /// 
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

        public static void AgregarCliente (Cliente cliente)
        {
            bool modificoClienteInactivo = false;
            foreach (Cliente miembro in clientesMiembros.Values)
            {
                if (miembro.Activo)
                {
                    if(miembro.Id == cliente.Id)
                    {
                        throw new Exception($"Ya existe un cliente registrado con el ID/DNI {cliente.Id}");
                    }
                    if(miembro.Mail == cliente.Mail)
                    {
                        throw new Exception($"Ya existe un cliente registrado con el mail {cliente.Mail}");
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
                            break;
                        }
                    }catch (Exception ex)
                    {
                        throw new Exception($"Ocurrio un error con los parametros del cliente ingresado: {ex.Message}",ex);
                    }
                }
            }
            if (!modificoClienteInactivo)
            {
                clientesMiembros.Add(cliente.Id, cliente);
            }
        }
    }
}
