using System;

namespace Tests.Intro
{
    public class Criptografia
    {
        public static string Criptografar(string entrada)
        {
            if (entrada == null || entrada.Trim().Length < 4)
            {
                throw new ArgumentException("Entrada é nula, vazia ou muito pequena.");
            }

            string saida1 = SomaTresAscii(entrada);
            string saida2 = InverteString(saida1);
            string saida3 = DeslocaSegundaMetade(saida2);

            return saida3;
        }

        public static string SomaTresAscii(string entrada)
        {
            string saida = "";
            for (int i = 0; i < entrada.Length; i++)
            {
                if (char.IsLetter(entrada[i]))
                {
                    saida += (char)(entrada[i] + 3);
                }
                else
                {
                    saida += entrada[i];
                }
            }

            return saida;

        }

        public static string InverteString(string entrada)
        {
            char[] charArray = entrada.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string DeslocaSegundaMetade(string entrada)
        {
            int metade = (entrada.Length / 2);

            string saida = "";
            for (int i = 0; i < entrada.Length; i++)
            {
                if (i >= metade)
                {
                    saida += (char)(entrada[i] - 1);
                }
                else
                {
                    saida += entrada[i];
                }
            }

            return saida;
        }
    }
}
