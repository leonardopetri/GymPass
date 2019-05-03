using System;
using System.Collections.Generic;
using System.Linq;

namespace GymPass
{
    public class Piloto {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }

        public IList<Volta> Voltas { get; private set; }

        public Piloto(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;

            this.Voltas = new List<Volta>();
        }

        public TimeSpan CalcularTempoTotalProva()
        {
            var voltaInicial = this.Voltas.Where(x => x.Numero == 1).FirstOrDefault();
            var horarioInicioProva = voltaInicial.HoraFinal - voltaInicial.TempoVolta;
            var horarioFimProva = this.Voltas.Where(x => x.Numero == this.Voltas.Count).FirstOrDefault().HoraFinal;

            return horarioFimProva - horarioInicioProva;
        }

        public Volta RetonarMelhorVolta()
        {
            return this.Voltas.OrderBy(x => x.TempoVolta).First();
        }

        public double RetonarVelocidadeMedia()
        {
            return this.Voltas.Sum(x => x.VelocidadeMedia) / this.Voltas.Count();
        }

        public TimeSpan RetornarTempoAposVencedor(Piloto vencedor)
        {
            var tempoVencedor = vencedor.Voltas.OrderByDescending(x => x.HoraFinal).First().HoraFinal;
            var tempoPiloto = this.Voltas.OrderByDescending(x => x.HoraFinal).First().HoraFinal;

            return tempoPiloto - tempoVencedor;
        }
    }
}