using GymPass;
using System;
using Xunit;

namespace Testes
{
    public class CorridaDeveria
    {
        private readonly Corrida _corrida;

        public CorridaDeveria()
        {
            _corrida = CorridaFactory.Create(4, LeitorLog.LerLog("log.txt"));
        }

        [Fact]
        public void RetornarVercedor()
        {
            var vencedor = _corrida.RetornarVencedor();

            Assert.Equal(38, vencedor.Codigo);
        }

        [Fact]
        public void RetornarMelhorVolta()
        {
            var pilotoVolta = _corrida.RetonarMelhorVolta();

            Assert.Equal(38, pilotoVolta.Piloto.Codigo);
            Assert.Equal(3, pilotoVolta.Volta.Numero);
        }

        [Theory]
        [InlineData(38, 1)]
        [InlineData(33, 3)]
        [InlineData(2, 2)]
        [InlineData(23, 4)]
        [InlineData(15, 5)]
        [InlineData(11, 6)]
        public void RetornarPosicaoPiloto(int codigoPiloto, int posicaoEsperada)
        {
            var piloto = new Piloto(codigoPiloto);
            var posicao = _corrida.VerificarPosicaoPiloto(piloto);

            Assert.Equal(posicaoEsperada, posicao);
        }
    }
}
