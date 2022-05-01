using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        
        ETipo tipo;

        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas
        }

        #region "Constructores"

        /// <summary>
        /// Constructor de la clase Sedan, por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">valor de tipo enumerado EMarca con el que se setea el atributo marca</param>
        /// <param name="chasis">string con el que se setea el atributo chasis</param>
        /// <param name="color">valor de tipo ConsoleColor con el que se setea el atributo color</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        { }

        /// <summary>
        /// Constructor de la clase Sedan
        /// </summary>
        /// <param name="marca">valor de tipo enumerado EMarca con el que se setea el atributo marca</param>
        /// <param name="chasis">string con el que se setea el atributo chasis</param>
        /// <param name="color">valor de tipo ConsoleColor con el que se setea el atributo color</param>
        /// <param name="tipo">valor de tipo enumerado ETipo con el que se setea el atributo tipo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            :base(chasis,marca,color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// ReadOnly: Retornará el tamaño, que por defecto es Mediano
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Publica todos los datos del Sedan.
        /// </summary>
        /// <returns>retorna un string con los datos del Sedan</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMANIO : "+this.Tamanio);
            sb.AppendLine("TIPO: " + this.tipo);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

    }
}
