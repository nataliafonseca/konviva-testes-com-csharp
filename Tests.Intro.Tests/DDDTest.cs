using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class DDDTest
    {
        [Theory]
        [InlineData(-11)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(9)]
        [InlineData(100)]
        public void Quando_PassadoValorInvalido_Deve_RetornarExcecao(int ddd)
        {
            var exception = Assert.Throws<ArgumentException>(() => DDD.GetCidade(ddd));
        }

        [Theory]
        [InlineData(11, "São Paulo")]
        [InlineData(19, "Campinas")]
        [InlineData(21, "Rio de Janeiro")]
        [InlineData(27, "Vitória")]
        [InlineData(31, "Belo Horizonte")]
        [InlineData(32, "Juiz de Fora")]
        [InlineData(61, "Brasília")]
        [InlineData(71, "Salvador")]
        public void Quando_PassadoValorDaTabela_Deve_RetornarCidade(int ddd, string saidaEsperada)
        {
            var resposta = DDD.GetCidade(ddd);
            Assert.Equal(saidaEsperada, resposta);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(22)]
        [InlineData(23)]
        [InlineData(54)]
        public void Quando_PassadoValorNaoExistente_Deve_RetornarMensagem(int ddd)
        {
            string saidaEsperada = "DDD não encontrado";
            var resposta = DDD.GetCidade(ddd);
            Assert.Equal(saidaEsperada, resposta);
        }
    }
}
