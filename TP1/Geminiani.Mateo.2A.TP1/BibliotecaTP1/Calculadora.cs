using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza operaciones de 2 numeros pasados por parametro
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador">Simbolo de la operacion a realizar</param>
        /// <returns>Resultado de la operacion</returns>
        public double Operar(Operando num1, Operando num2, char operador)
        {
            double retorn;
            char op = ValidarOperador(operador);
            switch (op)
            {
                default:
                case '+':
                    retorn = num1 + num2;
                    break;
                case '-':
                    retorn = num1 - num2;
                    break;
                case '/':
                    retorn = num1 / num2;
                    break;
                case '*':
                    retorn = num1 * num2;
                    break;
            }
            return retorn;
        }
        /// <summary>
        /// Valida el operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>operador si es valido, de no serlo retorna +</returns>
        private static char ValidarOperador(char operador)
        {
            char retorn = '+';
            if(operador == '-' || operador == '/' || operador == '*')
            {
                retorn = operador;
            }
            return retorn;
        }
    }
}
