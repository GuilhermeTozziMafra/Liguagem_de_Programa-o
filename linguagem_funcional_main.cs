using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Filtrando os números pares
        var numerosPares = numeros.Where(x => x % 2 == 0);

        // Calculando o quadrado de cada número
        var quadrados = numerosPares.Select(x => x * x);

        // Somando os quadrados
        int somaDosQuadrados = quadrados.Sum();

        Console.WriteLine($"A soma dos quadrados dos números pares é: {somaDosQuadrados}");
    }
}
