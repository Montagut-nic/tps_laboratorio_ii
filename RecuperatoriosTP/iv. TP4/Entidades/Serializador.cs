using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializador : IGuardable<ArrayList>
    {
        private string path;

        /// <summary>
        /// constructor de la clase Serializador, setea el path y si el directorio no existe lo crea
        /// </summary>
        public Serializador()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\ArchivosTPFinal\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        /// <summary>
        /// implementacion del metodo Escribir de la interfaz IGuardable, su generic T es ArrayList, serializa los elementos del arraylist en un .json
        /// </summary>
        /// <param name="data"></param>
        public void Escribir(ArrayList data)
        {
            try 
            { 
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                string jsonString = String.Empty;
                StringBuilder sb = new StringBuilder();
                if (Directory.Exists(path)) 
                { 
                    foreach (object obj in data)
                    {
                        sb.AppendLine(JsonSerializer.Serialize(obj, opciones));
                        jsonString = sb.ToString();
                    }
                    File.WriteAllText(path + "productos.json", jsonString);
                }
                else
                {
                    Directory.CreateDirectory(path);
                    foreach (object obj in data)
                    {
                        sb.AppendLine(JsonSerializer.Serialize(obj, opciones));
                        jsonString = sb.ToString();
                    }
                    File.WriteAllText(path + "productos.json", jsonString);
                }
            }catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// implementacion del metodo Leer de la interfaz IGuardable, su generic T es ArrayList, 
        /// deserializa los productos del archivo .json y los retorna en un arraylist
        /// </summary>
        /// <returns></returns>
        public ArrayList Leer()
        {
            string archivo = string.Empty;
            string[] registroRecuperado;
            StringBuilder sb = new StringBuilder();
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
                        if (line.EndsWith('}'))
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
    }
}
