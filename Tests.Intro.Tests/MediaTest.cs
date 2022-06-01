using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class MediaTest
    {
        [Theory]
        [InlineData(2, 2, "2.0")]
        [InlineData(2, 4, "3.0")]
        [InlineData(2.5, 5.2, "3.9")]
        public void Quando_PassadoDoisValoresValidos_Deve_RetornarMedia(double num1, double num2, string saidaEsperada)
        {
            var retorno = Media.Simples(num1, num2);

            Assert.Equal(saidaEsperada, retorno);
        }


        [Theory]
        [InlineData(5, 6, 7, "6.0")]
        [InlineData(5, 10, 10, "8.3")]
        [InlineData(10.5, 6.2, 7.8, "8.2")]
        public void Quando_PassadoTresValoresValidos_Deve_RetornarMedia(double num1, double num2, double num3, string saidaEsperada)
        {
            var retorno = Media.Simples(num1, num2, num3);

            Assert.Equal(saidaEsperada, retorno);
        }

        [Theory]
        [InlineData(2, -2)]
        [InlineData(-2, 4)]
        [InlineData(-2, -4)]
        public void Quando_PassadoDuasEntradasEHouverInvalida_Deve_RetornarExcecao(double num1, double num2)
        {
            const string mensagemEsperada = "Os valores devem ser positivos.";

            var exception = Assert.Throws<ArgumentException>(() => Media.Simples(num1, num2));

            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Theory]
        [InlineData(-2, 2, 1)]
        [InlineData(2, -4, 1)]
        [InlineData(2, 4, -1)]
        [InlineData(-2, -4, 1)]
        [InlineData(2, -4, -1)]
        [InlineData(-2, 4, -1)]
        [InlineData(-2, -4, -1)]
        public void Quando_PassadoTresEntradasEHouverInvalida_Deve_RetornarExcecao(double num1, double num2, double num3)
        {
            const string mensagemEsperada = "Os valores devem ser positivos.";

            var exception = Assert.Throws<ArgumentException>(() => Media.Simples(num1, num2, num3));

            Assert.Equal(mensagemEsperada, exception.Message);
        }
    }
}
