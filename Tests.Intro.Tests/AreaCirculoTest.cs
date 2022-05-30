using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class AreaCirculoTest
    {
        [Theory]
        [InlineData(2, "12.5664")]
        [InlineData(100.64, "31819.3103")]
        [InlineData(150, "70685.7750")]
        public void CalculoTest(double entrada, string saidaEsperada)
        {
            var retorno = AreaCirculo.Calculo(entrada);

            Assert.Equal(retorno, saidaEsperada);
        }

        [Fact]
        public void Quando_PassadoZero_Deve_RetornarZero()
        {
            var entrada = 0;
            var saidaEsperada = "0";
            var retorno = AreaCirculo.Calculo(entrada);

            Assert.Equal(retorno, saidaEsperada);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-2.564)]
        public void Quando_PassadoValorInvalido_Deve_RetornarExcecao(double entrada)
        {
            const string mensagemEsperada = "Raio deve ser positivo.";

            var exception = Assert.Throws<ArgumentException>(() => AreaCirculo.Calculo(entrada));

            Assert.Equal(exception.Message, mensagemEsperada);
        }
    }
}