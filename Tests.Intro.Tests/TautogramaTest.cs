using System;
using Xunit;

namespace Tests.Intro.Tests
{
  public class TautogramaTest
  {
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("Palavra")]
    public void Quando_PassadoValorInvalido_Deve_RetornarExcecao(string entrada)
    {
      string mensagemEsperada = "Frase inválida.";

      var excecao = Assert.Throws<ArgumentException>(() => Tautograma.Validar(entrada));

      Assert.Equal(mensagemEsperada, excecao.Message);
    }

    [Theory]
    [InlineData("Flowers Flourish from France", "S")]
    [InlineData("Sam Simmonds speaks softly", "S")]
    [InlineData("Peter pIckEd pePPers", "S")]
    [InlineData("truly tautograms triumph", "S")]
    [InlineData("Isso não é um Tautograma", "N")]
    public void Quando_PassadoValorValido_Deve_RetornarResultado(string entrada, string saidaEsperada)
    {
      var retorno = Tautograma.Validar(entrada);

      Assert.Equal(saidaEsperada, retorno);
    }


  }
}
