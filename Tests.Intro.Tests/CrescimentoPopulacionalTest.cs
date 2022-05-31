using System;
using Xunit;

namespace Tests.Intro.Tests
{
  public class CrescimentoPopulacionalTest
  {
    [Theory]
    [InlineData(-100, 150, 1.0, 1.2)]
    [InlineData(100, -150, 1.0, 1.2)]
    [InlineData(-100, -150, 1.0, 1.2)]
    public void Quando_PassadoPopulacaoNegativa_Deve_RetornarExcecao(int popA, int popB, double crescA, double crescB)
    {
      string mensagemEsperada = "População não pode ser negativa.";

      var excecao = Assert.Throws<ArgumentException>(() => CrescimentoPopulacional.Calcular(popA, popB, crescA, crescB));

      Assert.Equal(mensagemEsperada, excecao.Message);
    }

    [Theory]
    [InlineData(151, 150, 1.0, 1.2)]
    [InlineData(1100, 150, 1.0, 1.2)]
    [InlineData(100, 0, 1.0, 1.2)]
    public void Quando_PopulacaoAJaEIgualOuMaior_Deve_RetornarExcecao(int popA, int popB, double crescA, double crescB)
    {
      string mensagemEsperada = "População da cidade A já é maior ou igual.";

      var excecao = Assert.Throws<ArgumentException>(() => CrescimentoPopulacional.Calcular(popA, popB, crescA, crescB));

      Assert.Equal(mensagemEsperada, excecao.Message);
    }

    [Theory]
    [InlineData(100, 150, 1.0, 1.2)]
    [InlineData(149, 150, 1.0, 1.2)]
    // Sempre cairá no caso anterior!
    // [InlineData(0, 0, 1.0, 1.2)]
    public void Quando_PopulacaoATemCrescimentoInferior_Deve_RetornarExcecao(int popA, int popB, double crescA, double crescB)
    {
      string mensagemEsperada = "Cidade A nunca terá uma população maior que a cidade B";

      var excecao = Assert.Throws<ArgumentException>(() => CrescimentoPopulacional.Calcular(popA, popB, crescA, crescB));

      Assert.Equal(mensagemEsperada, excecao.Message);
    }



    [Theory]
    [InlineData(100, 150, 1.0, 0, "51 anos.")]
    [InlineData(90000, 120000, 5.5, 3.5, "16 anos.")]
    [InlineData(56700, 72000, 5.2, 3.0, "12 anos.")]
    [InlineData(123, 2000, 3.0, 2.0, "Mais de 1 século.")]
    [InlineData(100000, 110000, 1.5, 0.5, "10 anos.")]
    [InlineData(62422, 484317, 3.1, 1.0, "100 anos.")]
    [InlineData(100, 150, 4.5, 4.0, "95 anos.")]
    public void Quando_PassadosValoresValidos_Deve_RetornarTempo(int popA, int popB, double crescA, double crescB, string resultadoEsperado)
    {
      var retorno = CrescimentoPopulacional.Calcular(popA, popB, crescA, crescB);

      Assert.Equal(resultadoEsperado, retorno);
    }
  }
}
