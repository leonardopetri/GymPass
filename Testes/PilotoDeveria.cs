using GymPass;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testes
{
    public class PilotoDeveria
    {
        private readonly Corrida _corrida;

        public PilotoDeveria()
        {
            _corrida = CorridaFactory.Create(4, LeitorLog.LerLog("log.txt"));
        }

        [Theory]
        [InlineData(38, 3)]
        [InlineData(33, 3)]
        [InlineData(2, 4)]
        [InlineData(23, 4)]
        [InlineData(15, 2)]
        [InlineData(11, 3)]
        public void RetornarMelhorVolta(int codigoPiloto, int melhorVoltaEsperada)
        {
            var melhorVolta = _corrida.Pilotos[codigoPiloto].RetonarMelhorVolta().Numero;

            Assert.Equal(melhorVoltaEsperada, melhorVolta);
        }

        [Theory]
        [InlineData(38, 44.246)]
        [InlineData(33, 43.468)]
        [InlineData(2, 43.627)]
        [InlineData(23, 43.191)]
        [InlineData(15, 38.066)]
        [InlineData(11, 25.746)]
        public void RetornarVelocidadeMedia(int codigoPiloto, double velocidadeMediaEsperada)
        {
            var velocidadeMedia = Math.Round(_corrida.Pilotos[codigoPiloto].RetonarVelocidadeMedia(), 3);

            Assert.Equal(velocidadeMediaEsperada, velocidadeMedia);
        }

        [Theory]
        [InlineData(38, "00:04:11.5780000")]
        [InlineData(33, "00:04:16.0800000")]
        [InlineData(2, "00:04:15.1530000")]
        [InlineData(23, "00:04:17.7220000")]
        [InlineData(15, "00:04:54.2210000")]
        [InlineData(11, "00:06:27.2760000")]
        public void CalcularTempoTotalProva(int codigoPiloto, string tempoTotalEsperadoStr)
        {
            var tempoTotalEsperado = TimeSpan.Parse(tempoTotalEsperadoStr);
            var tempoTotal = _corrida.Pilotos[codigoPiloto].CalcularTempoTotalProva();

            Assert.Equal(tempoTotalEsperado, tempoTotal);
        }

        [Theory]
        [InlineData(38, "00:00:00")]
        [InlineData(33, "00:00:05.5830000")]
        [InlineData(2, "00:00:05.1170000")]
        [InlineData(23, "00:00:08.9720000")]
        [InlineData(15, "00:00:49.7380000")]
        [InlineData(11, "00:02:40.7540000")]
        public void RetornarTempoAposVencedor(int codigoPiloto, string tempoAposVencedorEsperadoStr)
        {
            var vencedor = _corrida.RetornarVencedor();
            var tempoAposVencedorEsperado = TimeSpan.Parse(tempoAposVencedorEsperadoStr);
            var tempoAposVencedor = _corrida.Pilotos[codigoPiloto].RetornarTempoAposVencedor(vencedor);

            Assert.Equal(tempoAposVencedorEsperado, tempoAposVencedor);
        }
    }
}
