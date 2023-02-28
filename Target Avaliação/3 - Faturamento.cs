using System;
using Newtonsoft.Json.Linq;

class Program {
    static void Main(string[] args) {
        // ler os dados do arquivo json
        string json = System.IO.File.ReadAllText(@"caminho/do/arquivo.json");
        JObject faturamentoMensal = JObject.Parse(json);

        // extrair os valores de faturamento diário para um array
        JArray faturamentoDiario = (JArray) faturamentoMensal["faturamento_diario"];

        // calcular o menor e o maior valor de faturamento
        decimal menorFaturamento = decimal.MaxValue;
        decimal maiorFaturamento = decimal.MinValue;

        foreach (decimal faturamento in faturamentoDiario) {
            if (faturamento < menorFaturamento) {
                menorFaturamento = faturamento;
            }
            if (faturamento > maiorFaturamento) {
                maiorFaturamento = faturamento;
            }
        }

        // calcular a média mensal
        decimal mediaMensal = 0;
        int numeroDiasComFaturamento = 0;

        foreach (decimal faturamento in faturamentoDiario) {
            if (faturamento > 0) {
                mediaMensal += faturamento;
                numeroDiasComFaturamento++;
            }
        }

        mediaMensal /= numeroDiasComFaturamento;

        // contar o número de dias em que o faturamento foi maior que a média mensal
        int numeroDiasAcimaDaMedia = 0;

        foreach (decimal faturamento in faturamentoDiario) {
            if (faturamento > mediaMensal) {
                numeroDiasAcimaDaMedia++;
            }
        }

        Console.WriteLine("Menor faturamento: " + menorFaturamento);
        Console.WriteLine("Maior faturamento: " + maiorFaturamento);
        Console.WriteLine("Número de dias com faturamento acima da média: " + numeroDiasAcimaDaMedia);
    }
}