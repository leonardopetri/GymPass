using System;

namespace GymPass
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroVoltas = 4;

            if (args.Length > 0)
                int.TryParse(args[0], out numeroVoltas);

            var corrida = CorridaFactory.Create(numeroVoltas);
            GeradorResultado.GerarResultado(corrida);
            
            foreach (var piloto in corrida.Pilotos)
            {
                var melhorVolta = piloto.Value.RetonarMelhorVolta();
                Console.WriteLine($"Melhor volta {piloto.Value.Nome}: {melhorVolta.Numero} ({melhorVolta.TempoVolta})");
            }

            var melhorVoltaCorrida = corrida.RetonarMelhorVolta();
            Console.WriteLine();
            Console.WriteLine($"Melhor volta Corrida: Piloto {melhorVoltaCorrida.Piloto.Nome} Volta - {melhorVoltaCorrida.Volta.Numero} ({melhorVoltaCorrida.Volta.TempoVolta})");

            Console.WriteLine();
            foreach (var piloto in corrida.Pilotos)
            {
                var velocidadeMedia = piloto.Value.RetonarVelocidadeMedia();
                Console.WriteLine($"Velocidade Media {piloto.Value.Nome}: {velocidadeMedia}");
            }

            Console.WriteLine();
            Console.WriteLine("Tempo apos o vencedor:");
            var pilotoVencedor = corrida.RetornarVencedor();
            foreach (var piloto in corrida.Pilotos)
            {
                var tempoAposVencedor = piloto.Value.RetornarTempoAposVencedor(pilotoVencedor);
                Console.WriteLine($"{piloto.Value.Nome}: {tempoAposVencedor}");
            }

            Console.ReadKey();
        }
    }
}
