using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public class DDD
    {
        public static Dictionary<int, string> cidades = new Dictionary<int, string>()
        {
            { 11, "São Paulo" },
            { 19, "Campinas" },
            { 21, "Rio de Janeiro" },
            { 27, "Vitória" },
            { 31, "Belo Horizonte" },
            { 32, "Juiz de Fora" },
            { 61, "Brasília" },
            { 71, "Salvador" }
        };
        public static string GetCidade(int ddd)
        {
            if (ddd < 10 || ddd > 99)
            {
                throw new ArgumentException("DDD inválido");
            }

            if (cidades.ContainsKey(ddd))
            {
                return cidades[ddd];
            }
            else
            {
                return "DDD não encontrado";
            }
        }
    }
}
