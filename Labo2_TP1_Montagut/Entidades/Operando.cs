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

        public string BinarioDecimal(string binario)
        {
            char[] bufferBinario= binario.ToCharArray();
            Array.Reverse(bufferBinario);
            int numeroInt=0;
            if (EsBinario(binario))
            {
                for(int i=0; i < bufferBinario.Length; i++)
                {
                    if (bufferBinario[i]=='1')
                    {
                        numeroInt += (int)Math.Pow(2, i);
                    }
                }
                return numeroInt.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }

        public string DecimalBinario(double numero)
        {
            string binarioStr = String.Empty;
            int numeroInt = (int)Math.Abs(numero);
            if (numeroInt == 0) 
            {
                binarioStr = "0";
            }
            else
            {
                do
                {
                    binarioStr = (int)numeroInt%2 + binarioStr;
                    numeroInt = (int) numeroInt/2;
                } while (numeroInt>0);
            }
            return binarioStr;
        }

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

        private static bool EsBinario (string binario) 
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

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(String strNumero)
        {
            this.Numero = strNumero;
        }

        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

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

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        private static double ValidarOperando(string strNumero)
        {
            Double.TryParse(strNumero, out double retorno);
            return retorno;
        }
    }
}
