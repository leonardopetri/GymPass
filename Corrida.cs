using System.Collections.Generic;
using System.Linq;

namespace GymPass
{
    public class Corrida {
        public int NumeroVoltas { get; private set; }
        public IDictionary<int, Piloto> Pilotos { get; private set; }

        public Corrida(int numeroVoltas)
        {
            this.NumeroVoltas = numeroVoltas;
            this.Pilotos = new Dictionary<int, Piloto>();
        }

        public int VerificarPosicaoPiloto(Piloto piloto)
        {
            var pilotosUltimaVolta = this.Pilotos
                .Select(x => new { Codigo = x.Key, NumeroVoltas = x.Value.Voltas.Count, x.Value.Voltas.OrderByDescending(y => y.HoraFinal).First().HoraFinal })
                .OrderByDescending(n => n.NumeroVoltas).OrderBy(v => v.HoraFinal).ToList();

            var posicao = 0;
            foreach (var pl in pilotosUltimaVolta)
            {
                posicao++;
                if (pl.Codigo == piloto.Codigo)
                    break;
            }

            return posicao;
        }

        public Piloto RetornarVencedor()
        {
            return this.Pilotos
                .Select(x => new { Piloto = x.Value, NumeroVoltas = x.Value.Voltas.Count, x.Value.Voltas.OrderByDescending(y => y.HoraFinal).First().HoraFinal })
                .OrderByDescending(n => n.NumeroVoltas).OrderBy(v => v.HoraFinal).FirstOrDefault().Piloto;
        }
        
        public (Piloto Piloto, Volta Volta) RetonarMelhorVolta()
        {
            var melhorVolta = this.Pilotos
                .Select(x => new { Piloto = x.Value, Volta = x.Value.Voltas.OrderBy(y => y.TempoVolta).First() })
                .OrderBy(c => c.Volta.TempoVolta).First();

            return (melhorVolta.Piloto, melhorVolta.Volta);
        }
    }
}