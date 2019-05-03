using System;

namespace GymPass
{
    public class Volta {
        public int Numero { get; private set; }
        public TimeSpan HoraFinal { get; private set; }
        public TimeSpan TempoVolta { get; private set; }
        public double VelocidadeMedia { get; private set; }

        public Volta(int numero, TimeSpan horaFinal, TimeSpan tempoVolta, double velocidadeMedia)
        {
            this.Numero = numero;
            this.HoraFinal = horaFinal;
            this.TempoVolta = tempoVolta;
            this.VelocidadeMedia = velocidadeMedia;
        }
    }
}