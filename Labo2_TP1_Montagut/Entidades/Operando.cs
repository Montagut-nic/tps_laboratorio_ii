using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Recibe un numero binario en formato string, lo valida y trnasforma a decimal en formato string y lo devuelve
        /// </summary>
        /// <param name="binario">Es un numero binario en formato string</param>
        /// <returns>Retorna el numero decimal en formato string si todo esta bien, o retorna Valor inválido si el string no es un numero binario</returns>
        public string BinarioDecimal(string binario)
        {
            char[] bufferBinario= binario.ToCharArray();
            Array.Reverse(bufferBinario);
            // ejemplo, 1010 queda como 0101 
            int numeroInt=0;
            if (EsBinario(binario))
            {
                for(int i=0; i < bufferBinario.Length; i++)
                {
                    if (bufferBinario[i]=='1')
                    {
                        numeroInt += (int)Math.Pow(2, i);
                        // siguiendo el ejemplo, por bufferBinario[1] se eleva 2 a la 1 y se suma a numeroInt (2), por bufferBinario[3] se eleva
                        // 2 a la 3 y se suma a numeroInt (2+8), queda que 1010 binario es igual a 10 decimal
                    }
                }
                return numeroInt.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Recibe un numero decimal en formato double y lo devuelve como binario en string
        /// </summary>
        /// <param name="numero">Es el numero decimal a transformar en binario y devolver como string</param>
        /// <returns>Retorna cero como string si el numero es cero o retorna el numero como binario en un string</returns>
        public string DecimalBinario(double numero)
        {
            string binarioStr = String.Empty;
            // se queda con el valor absoluto y entero del double recibido
            int numeroInt = (int)Math.Abs(numero);
            if (numeroInt == 0) 
            {
                binarioStr = "0";
            }
            else
            {
                do
                {
                    // se va agregando el resto al inicio del string
                    binarioStr = (int) numeroInt%2 + binarioStr;
                    numeroInt = (int) numeroInt/2;
                } while (numeroInt>0);
            }
            return binarioStr;
        }


        /// <summary>
        ///Recibe un numero decimal en formato string y lo devuelve como binario en string
        /// </summary>
        /// <param name="dato">Es el numero decimal en string a transformar y devolver como binario en string</param>
        /// <returns>Retorna Valor inválido si no se puede transformar el numero en string a formato double, o retorna un string del numero como binario si todo esta bien</returns>
        public string DecimalBinario(string numero)
        {
            if(Double.TryParse(numero, out double numeroDouble))
            {
                return DecimalBinario(numeroDouble);
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Valida que un string contenga un numero binario, solo admite 1 y 0
        /// </summary>
        /// <param name="binario">Es el string que contiene el numero binario a validar</param>
        /// <returns>retorna false si contiene por lo menos un caracter que no sea un 1 o 0, en caso contrario retorna true</returns>
        private bool EsBinario (string binario) 
        {
            bool retorno=true;
            for (int i = 0; i < binario.Length-1; i++)
            {
                if(binario[i]!='0' && binario[i] != '1') 
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Constructor de la clase Operando, setea numero en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        ///  Constructor de la clase Operando, setea el atributo numero con el valor de numero
        /// </summary>
        /// <param name="numero">Double con el que se setea el atributo numero</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de la clase Operando, setea el atributo numero con el valor del string strNumero a traves de la propiedad Numero
        /// </summary>
        /// <param name="strNumero">string con el que se setea el atributo numero</param>
        public Operando(String strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Hace una resta entre dos numeros doubles
        /// </summary>
        /// <param name="n1">Primer numero de la resta</param>
        /// <param name="n2">Segundo numero de la resta</param>
        /// <returns>retorna el resultado de la resta entre dos numeros double</returns>
        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Hace una multiplicacion entre dos numeros doubles
        /// </summary>
        /// <param name="n1">Primer numero de la multiplicacion</param>
        /// <param name="n2">Segundo numero de la multiplicacion</param>
        /// <returns>retorna el resultado de la multiplicacion de dos numeros double</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Hace una division entre dos numeros doubles
        /// </summary>
        /// <param name="n1">Dividendo</param>
        /// <param name="n2">Divisor</param>
        /// <returns>retorna el resultado de la division de dos numeros double o double.MinValue si el divisor es 0</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0) 
            {
                return n1.numero / n2.numero;
            }
            else
            {
                return double.MinValue;
            }
        }

        /// <summary>
        /// Hace una suma entre dos numeros doubles
        /// </summary>
        /// <param name="n1">Primer numero de la suma</param>
        /// <param name="n2">Segundo numero de la suma</param>
        /// <returns>retorna el resultado de la suma de dos numeros double</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Valida que un string sea un numero double y lo retorna
        /// </summary>
        /// <param name="strNumero">string a validar</param>
        /// <returns>retorna el numero como double o 0 si no se pudo convertir a double</returns>
        private static double ValidarOperando(string strNumero)
        {
            // si TryParse falla, en out devuelve 0
            Double.TryParse(strNumero, out double retorno);
            return retorno;
        }
    }
}
