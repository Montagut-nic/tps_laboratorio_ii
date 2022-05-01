using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {

        #region "Constructores"

        /// <summary>
        /// Constructor de la clase SUV
        /// </summary>
        /// <param name="marca">valor de tipo enumerado EMarca con el que se setea el atributo marca</param>
        /// <param name="chasis">string con el que se setea el atributo chasis</param>
        /// <param name="color">valor de tipo ConsoleColor con el que se setea el atributo color</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        { }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// ReadOnly: Retornará el tamaño, que por defecto es Grande
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Publica todos los datos del SUV.
        /// </summary>
        /// <returns>retorna un string con los datos del SUV</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMANIO : "+this.Tamanio);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
