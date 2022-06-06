using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clEntidades
{
    public class Metodos
    {
        public static void Swap<T>(List<T> lista, int indiceX, int indiceY)
        {
            T aux = lista[indiceX];
            lista[indiceX] = lista[indiceY];
            lista[indiceY] = aux;
        }
    }
}
