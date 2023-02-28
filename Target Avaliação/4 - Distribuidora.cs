using System;

class Program {
    static void Main(string[] args) {
        decimal faturamentoTotal = 181759.98M;
        decimal faturamentoSP = 67836.43M;
        decimal faturamentoRJ = 36678.66M;
        decimal faturamentoMG = 29229.88M;
        decimal faturamentoES = 27165.48M;
        decimal faturamentoOutros = 19849.53M;

        // calcular o percentual de representação de cada estado
        decimal percentualSP = (faturamentoSP / faturamentoTotal) * 100;
        decimal percentualRJ = (faturamentoRJ / faturamentoTotal) * 100;
        decimal percentualMG = (faturamentoMG / faturamentoTotal) * 100;
        decimal percentualES = (faturamentoES / faturamentoTotal) * 100;
        decimal percentualOutros = (faturamentoOutros / faturamentoTotal) * 100;

        Console.WriteLine("Percentual de representação do estado de SP: " + percentualSP.ToString("0.00") + "%");
        Console.WriteLine("Percentual de representação do estado do RJ: " + percentualRJ.ToString("0.00") + "%");
        Console.WriteLine("Percentual de representação do estado de MG: " + percentualMG.ToString("0.00") + "%");
        Console.WriteLine("Percentual de representação do estado do ES: " + percentualES.ToString("0.00") + "%");
        Console.WriteLine("Percentual de representação dos outros estados: " + percentualOutros.ToString("0.00") + "%");
    }
}