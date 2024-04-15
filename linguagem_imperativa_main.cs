using System;

namespace OperacoesComNumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gerar dois números aleatórios entre 1 e 100
            Random gerador = new Random();
            int numero1 = gerador.Next(1, 101);
            int numero2 = gerador.Next(1, 101);

            // Exibir os números gerados
            Console.WriteLine("Número 1: " + numero1);
            Console.WriteLine("Número 2: " + numero2);

            // Realizar as operações matemáticas
            int soma = numero1 + numero2;
            int subtracao = numero1 - numero2;
            int multiplicacao = numero1 * numero2;
            double divisao = (double)numero1 / numero2; // Conversão para double para evitar divisão por zero

            // Exibir os resultados das operações
            Console.WriteLine("\nSoma: " + soma);
            Console.WriteLine("\nSubtração: " + subtracao);
            Console.WriteLine("\nMultiplicação: " + multiplicacao);
            Console.WriteLine("\nDivisão: " + divisao);
        }
    }
}


