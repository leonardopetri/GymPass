using System.IO;

namespace GymPass
{
    public static class GeradorResultado
    {
        public static void GerarResultado(Corrida corrida, string file)
        {
            using (var sr = new StreamWriter(file))
            {
                var posicaoChegadaHeader = "Posição Chegada    ";
                var codigoPilotoHeader = "Código Piloto    ";
                var nomePilotoHeader = "Nome Piloto      ";
                var qtdVoltasHeader = "Qtde Voltas Completadas    ";
                var tempoTotalHeader = "Tempo Total de Prova";

                sr.WriteLine(string.Concat(posicaoChegadaHeader, codigoPilotoHeader, nomePilotoHeader, qtdVoltasHeader, tempoTotalHeader));

                foreach (var piloto in corrida.Pilotos)
                {
                    string linha = string.Empty;

                    var posicao = corrida.VerificarPosicaoPiloto(piloto.Value).ToString();
                    linha += posicao + new string(' ', posicaoChegadaHeader.Length - posicao.Length);

                    linha += piloto.Value.Codigo.ToString("000") + new string(' ', codigoPilotoHeader.Length - piloto.Value.Codigo.ToString("000").Length);
                    linha += piloto.Value.Nome + new string(' ', nomePilotoHeader.Length - piloto.Value.Nome.Length);
                    linha += piloto.Value.Voltas.Count + new string(' ', qtdVoltasHeader.Length - piloto.Value.Voltas.Count.ToString().Length);

                    var tempoTotal = piloto.Value.CalcularTempoTotalProva().ToString();
                    linha += tempoTotal + new string(' ', tempoTotalHeader.Length - tempoTotal.Length);

                    sr.WriteLine(linha);
                }
            }
        }
    }
}
