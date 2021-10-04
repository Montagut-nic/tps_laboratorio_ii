using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public sealed class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;

        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"

        /// <summary>
        /// Constructor de la clase Taller, por defecto su espacioDisponible sera 0
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor de la clase Taller, setea el espacioDisponible
        /// </summary>
        /// <param name="espacioDisponible">cantidad de espacio dispoible a setear</param>
        public Taller(int espacioDisponible)
            :this()
        {
            if (espacioDisponible > 0) 
            { 
                this.espacioDisponible = espacioDisponible;
            }
        }
        #endregion

        #region "Sobrecargas"

        /// <summary>
        /// Muestro el taller y TODOS los vehículos
        /// </summary>
        /// <returns>retorna un string con los datos del taller y de todos los vehiculos del taller</returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Muestra los datos del taller y su lista de vehiculos (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="t">Elemento a mostrar</param>
        /// <param name="tipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller t, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", t.vehiculos.Count, t.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in t.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.SUV:
                        if(v is Suv) 
                        { 
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"

        /// <summary>
        /// Agregará un elemento a la lista de vehiculos del taller
        /// </summary>
        /// <param name="t">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns>retorna el taller</returns>
        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            if (t.espacioDisponible > t.vehiculos.Count) 
            { 
                foreach (Vehiculo v in t.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        return t;
                    }
                }
                t.vehiculos.Add(vehiculo);
            }
            return t;
        }
        /// <summary>
        /// Quitará un elemento de la lista de vehiculos del taller
        /// </summary>
        /// <param name="t">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>retorna el taller</returns>
        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            if (t.vehiculos.Count > 0) 
            { 
                t.vehiculos.Remove(vehiculo);
            }
            return t;
        }
        #endregion
    }
}
