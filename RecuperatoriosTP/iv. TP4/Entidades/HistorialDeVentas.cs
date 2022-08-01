using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HistorialDeVentas : IGuardable<string>
    {
        private string path;
        
        /// <summary>
        /// constructor de la clase historial de ventas, setea el path y crea el directorio en el path si no existe
        /// </summary>
        public HistorialDeVentas()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\ArchivosTPFinal\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        /// <summary>
        /// implementacion del metodo Escribir de la interfaz IGuardable, su generic T es string, guarda la informacion de los tickets de venta en un archivo txt, 
        /// si no existe el archivo lo crea, de lo contrario agrega linesa, no sobreescribe
        /// </summary>
        /// <param name="data"></param>
        public void Escribir(string data)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(path + "Historial-De-Ventas-" + DateTime.Today.ToString("MM-yyyy") + ".txt", true);
                data.Split('\n').ToList().ForEach(x => streamWriter.WriteLine(x));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                streamWriter.Close();
                streamWriter.Dispose();
            }
        }

        /// <summary>
        /// implementacion del metodo Escribir de la interfaz IGuardable, su generic T es string, recupera informacion de los tickets de venta del mes guardada en un archivo .txt, la retorna en forma de string
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Leer()
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
                        if (pathArchivo.Contains(DateTime.Today.ToString("MM-yyyy")) && pathArchivo.Contains(".txt"))
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

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo del {DateTime.Today.ToString("MM - yyyy")} ubicado en {path}", e);
            }
        }
    }
}
