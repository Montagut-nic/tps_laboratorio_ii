using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        public enum EMarca
        {
            Chevrolet=1,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }

        public enum ETamanio
        {
            Chico=1,
            Mediano,
            Grande
        }

        #region "Constructores"

        /// <summary>
        /// Constructor de la clase Vehiculo
        /// </summary>
        /// <param name="marca">valor de tipo enumerado EMarca con el que se setea el atributo marca</param>
        /// <param name="chasis">string con el que se setea el atributo chasis</param>
        /// <param name="color">valor de tipo ConsoleColor con el que se setea el atributo color</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio
        {
            get;
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>retorna un string con los datos del Vehiculo</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        #endregion

        #region "Sobrecargas"

        /// <summary>
        /// Recibe un Vehiculo, retorna un string con los datos del Vehiculo
        /// </summary>
        /// <param name="p">vehiculo cuyos datos se van a retornar</param>
        /// <returns>retorna un string con los datos del Vehiculo</returns>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CHASIS: "+p.chasis);
            sb.AppendLine("MARCA : "+p.marca);
            sb.AppendLine("COLOR : "+p.color);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Determina si el chasis de dos vehiculos son iguales
        /// </summary>
        /// <param name="v1">primer vehiculo a comparar</param>
        /// <param name="v2">segundo vehiculo a comparar</param>
        /// <returns>retorna true si el chasis es igual, de lo contrario devolvera false</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        /// <summary>
        /// Determina si el chasis de dos vehiculos son distintos
        /// </summary>
        /// <param name="v1">primer vehiculo a comparar</param>
        /// <param name="v2">segundo vehiculo a comparar</param>
        /// <returns>retorna true si el chasis es distinto, de lo contrario devolvera false</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion


    }
}
