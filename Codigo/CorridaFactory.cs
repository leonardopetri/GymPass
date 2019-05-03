using System;
using System.Globalization;

namespace GymPass
{
    public static class CorridaFactory
    {
        public static Corrida Create(int numeroVoltas)
        {
            var corrida = new Corrida(numeroVoltas);

            var linhasLog = LeitorLog.LerLog();

            foreach (var linha in linhasLog)
            {
                var horaFinalVolta = TimeSpan.Parse(linha.Hora);
                var codigoPiloto = int.Parse(linha.CodigoPiloto);
                var nomePiloto = linha.NomePiloto;
                var numeroVolta = int.Parse(linha.NumeroVolta);
                var velocidadeMedia = double.Parse(linha.VelocidadeMedia);

                if (!TimeSpan.TryParseExact(linha.TempoVolta, @"m\:ss\.fff", CultureInfo.InvariantCulture, out TimeSpan tempoVolta))
                {
                    if (!TimeSpan.TryParseExact(linha.TempoVolta, @"mm\:ss\.fff", CultureInfo.InvariantCulture, out tempoVolta))
                    {
                        if (!TimeSpan.TryParseExact(linha.TempoVolta, @"h\:mm\:ss\.fff", CultureInfo.InvariantCulture, out tempoVolta))
                        {
                            throw new Exception("Uma volta maior que 9 horas não é possível");
                        }
                    }
                }

                if (!corrida.Pilotos.TryGetValue(codigoPiloto, out Piloto piloto))
                {
                    piloto = new Piloto(codigoPiloto, nomePiloto);
                    corrida.Pilotos.Add(codigoPiloto, piloto);
                }

                piloto.Voltas.Add(new Volta(numeroVolta, horaFinalVolta, tempoVolta, velocidadeMedia));
            }

            return corrida;
        }
    }
}
