using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza una operacion matematica
        /// </summary>
        /// <param name="num1">Primer numero de la operacion</param>
        /// <param name="num2">Segundo numero de la operacion</param>
        /// <param name="operador">Operador que determina que operacion matematica se realiza</param>
        /// <returns>retorna el resultado de la operacion matematica como double</returns>
        public static double Operar(Operando num1,Operando num2,char operador) 
        {
            double retorno = 0;
            char operadorValidado = ValidarOperador(operador);
            switch (operadorValidado)
            {
                case '+':
                    retorno = num1 + num2;
                    break;
                case '-':
                    retorno = num1 - num2;
                    break;
                case '*':
                    retorno = num1 * num2;
                    break;
                case '/':
                    retorno = num1 / num2;
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// valida que el operador sea aplicable
        /// </summary>
        /// <param name="operador">char que se valida como operador</param>
        /// <returns>retorna el operador o + </returns>
        private static char ValidarOperador(char operador) 
        {
            switch (operador)
            {
                case '-':
                case '*':
                case '/':
                    return operador;
                default:
                    return '+';
            }
        }
    }
}
