using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class CriptografiaTest
    {
        [Theory]
        [InlineData("Texto #3", "3# rvzgV")]
        [InlineData("abcABC1", "1FECedc")]
        [InlineData("vxpdylY .ph", "ks. \\n{frzx")]
        [InlineData("vv.xwfxo.fd", "gi.r{hyz-xx")]
        public void Quando_RecebeEntradaValida_Deve_RetornarValorCriptografado(string entrada, string saidaEsperada)
        {
            var retorno = Criptografia.Criptografar(entrada);

            Assert.Equal(retorno, saidaEsperada);
        }


        [Theory]
        [InlineData("Tex")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Quando_RecebeEntradaInvalida_Deve_RetornarExcecao(string entrada)
        {
            const string mensagemEsperada = "Entrada é nula, vazia ou muito pequena.";

            var exception = Assert.Throws<ArgumentException>(() => Criptografia.Criptografar(entrada));

            Assert.Equal(exception.Message, mensagemEsperada);
        }
    }
}
