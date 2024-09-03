using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var faturaDiario = new[]
        {
            new { dia = 1, valor = 22174.1664 },
            new { dia = 2, valor = 24537.6698 },
            new { dia = 3, valor = 26139.6134 },
            new { dia = 4, valor = 0.0 },
            new { dia = 5, valor = 0.0 },
            new { dia = 6, valor = 26742.6612 },
            new { dia = 7, valor = 0.0 },
            new { dia = 8, valor = 42889.2258 },
            new { dia = 9, valor = 46251.174 },
            new { dia = 10, valor = 11191.4722 },
            new { dia = 11, valor = 0.0 },
            new { dia = 12, valor = 0.0 },
            new { dia = 13, valor = 3847.4823 },
            new { dia = 14, valor = 373.7838 },
            new { dia = 15, valor = 2659.7563 },
            new { dia = 16, valor = 48924.2448 },
            new { dia = 17, valor = 18419.2614 },
            new { dia = 18, valor = 0.0 },
            new { dia = 19, valor = 0.0 },
            new { dia = 20, valor = 35240.1826 },
            new { dia = 21, valor = 43829.1667 },
            new { dia = 22, valor = 18235.6852 },
            new { dia = 23, valor = 4355.0662 },
            new { dia = 24, valor = 13327.1025 },
            new { dia = 25, valor = 0.0 },
            new { dia = 26, valor = 0.0 },
            new { dia = 27, valor = 25681.8318 },
            new { dia = 28, valor = 1718.1221 },
            new { dia = 29, valor = 13220.495 },
            new { dia = 30, valor = 8414.61 }
        };

        var faturamentoPositivo = faturaDiario.Where(d => d.valor > 0).ToArray();

        // Menor valor de faturamento
        var menorValor = faturamentoPositivo.Min(d => d.valor);

        // Maior valor de faturamento
        var maiorValor = faturamentoPositivo.Max(d => d.valor);

        // Média mensal de faturamento
        var mediaMensal = faturamentoPositivo.Average(d => d.valor);

        // Número de dias com faturamento superior à média mensal
        var diasAcimaDaMedia = faturamentoPositivo.Count(d => d.valor > mediaMensal);

        // Exibindo os resultados
        Console.WriteLine($"Menor valor de faturamento: {menorValor:F2}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }
}
