using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public class Tautograma
    {
        public static string Validar(string entrada)
        {
            if (entrada == null)
            {
                throw new ArgumentException("Frase inválida.");
            }

            string[] EntradaArray = entrada.Trim().Split();

            if (EntradaArray.Length < 2)
            {
                throw new ArgumentException("Frase inválida.");
            }

            char CaractereInicial = entrada.ToLower()[0];
            foreach (string palavra in EntradaArray)
            {
                if (palavra.ToLower()[0] != CaractereInicial)
                {
                    return "N";
                }
            }

            return "S";
        }
    }
}
