using System;

namespace Entidades
{
    public class Calculadora
    {
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
