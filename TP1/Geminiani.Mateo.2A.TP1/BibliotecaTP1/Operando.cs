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
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double num) : this()
        {
            this.numero = num;
        }
        public Operando(string strNumero) : this()
        {
            double.TryParse(strNumero, out this.numero);
        }
        private double ValidarOperando(string strNum)
        {
            double retorn;
            if(!double.TryParse(strNum, out retorn))
            {
                retorn = 0;
            }
            return retorn;
        }
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        private bool EsBinario(string strBin)
        {
            bool retorn = true;
            foreach(var v in strBin)
            {
                if(v != '0' && v != '1')
                {
                    retorn = false;
                    break;
                }
            }
            return retorn;
        }
        public string DecimalBinario(string numeroEntero)
        {
            double valorNumerico;
            string retorn = "Valor invalido";
            if(double.TryParse(numeroEntero,out valorNumerico))
            {
                retorn = DecimalBinario(valorNumerico);
            }
            return retorn;
        }
        public string DecimalBinario(double numeroEntero)
        {
            string numeroBinario = "";
            int division = (int)numeroEntero;
            if (division >= 0)
            {
                do
                {
                    numeroBinario = (division % 2) + numeroBinario;
                    division = division / 2;
                } while (division > 0);
            }
            return numeroBinario;
        }
        public string BinarioDecimal(string numeroBinario)
        {
            string retorn = "Valor invalido";
            double numeroEntero = 0;
            double division;
            if(this.EsBinario(numeroBinario))
            {
                if(double.TryParse(numeroBinario, out division))
                {
                    for (int x = 0; division != 0; x++)
                    {
                        numeroEntero = numeroEntero + Math.Pow(2, x) * (division % 10);
                        division = Math.Floor(division / 10);
                    }
                    retorn = numeroEntero.ToString();
                }
            }
            return retorn;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {

            double retorn;
            if(n2.numero == 0)
            {
                retorn = double.MinValue;
            }
            else
            {
                retorn = n1.numero / n2.numero;
            }
            return retorn;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}
