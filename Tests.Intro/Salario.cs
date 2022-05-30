using System;

namespace Tests.Intro
{
    public static class Salario
    {
        public static string SalarioComBonus(double salario, double vendas)
        {
            if (salario < 500)
            {
                throw new ArgumentException("Salário deve ser válido, acima do piso de 500.");
            }

            if (vendas < 0)
            {
                throw new ArgumentException("Vendas não podem ser negativas.");
            }

            if (vendas == 0)
            {
                return salario.ToString("F2");
            }

            double salarioLiquido = salario + 0.15 * vendas;

            return salarioLiquido.ToString("F2");
        }
    }
}
