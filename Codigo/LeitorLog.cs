using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GymPass
{
    public static class LeitorLog
    {
        public static IList<LinhaLog> LerLog()
        {
            var log = new List<LinhaLog>();

            foreach (var linha in File.ReadLines("log.txt"))
            {
                var valores = linha.Split(null).Where(x => !"–".Equals(x.Trim()) && !string.IsNullOrWhiteSpace(x)).ToArray();

                log.Add(new LinhaLog()
                {
                    Hora = valores[0],
                    CodigoPiloto = valores[1],
                    NomePiloto = valores[2],
                    NumeroVolta = valores[3],
                    TempoVolta = valores[4],
                    VelocidadeMedia = valores[5]
                });
            }

            return log;
        }
    }
}
