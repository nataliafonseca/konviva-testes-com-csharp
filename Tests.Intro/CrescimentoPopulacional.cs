using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public class CrescimentoPopulacional
    {
        public static string Calcular(int popA, int popB, double crescA, double crescB)
        {
            if (popA < 0 || popB < 0)
            {
                throw new ArgumentException("População não pode ser negativa.");
            }

            if (popA > popB)
            {
                throw new ArgumentException("População da cidade A já é maior.");
            }

            if (crescA <= crescB)
            {
                throw new ArgumentException("Cidade A nunca terá uma população maior que a cidade B");
            }

            int cont = 0;
            while (popA <= popB && cont <= 100)
            {
                popA = (int)(popA * (1 + crescA / 100));
                popB = (int)(popB * (1 + crescB / 100));
                cont++;
            }

            if (cont > 100)
            {
                return "Mais de 1 século.";
            }
            return cont + " anos.";
        }
    }
}
