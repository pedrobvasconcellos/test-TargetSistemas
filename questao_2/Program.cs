using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um numero da sua escolha:");
        int numero = int.Parse(Console.ReadLine());

        string resultado = Fibonacci(numero);
        Console.WriteLine(resultado);
    }

    static string Fibonacci(int numero)
    {
        int a = 0;
        int b = 1;
        int soma = a + b;
        string sequencia = "0, 1";

        while (soma <= numero)
        {
            sequencia += $", {soma}";
            if (soma == numero)
            {
                return $"A sequência de Fibonacci até {numero} é: {sequencia}.\nO número {numero} pertence à sequência de Fibonacci.";
            }

            a = b;
            b = soma;
            soma = a + b;
        }

        return $"A sequência de Fibonacci até {numero} é: {sequencia}.\nO número {numero} não pertence à sequência de Fibonacci.";
    }
}
