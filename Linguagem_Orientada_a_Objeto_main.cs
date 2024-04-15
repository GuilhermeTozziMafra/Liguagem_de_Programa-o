using System;

// Definição da classe abstrata Veiculo
abstract class Veiculo
{
    // Propriedades da classe
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    // Método construtor
    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    // Método abstrato para exibir informações específicas do veículo
    public abstract void ExibirDetalhes();
}

// Definição da classe Carro, que herda de Veiculo
class Carro : Veiculo
{
    // Propriedades específicas de Carro
    public int Portas { get; set; }

    // Método construtor
    public Carro(string marca, string modelo, int ano, int portas) : base(marca, modelo, ano)
    {
        Portas = portas;
    }

    // Implementação do método ExibirDetalhes para Carro
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Tipo: Carro, Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Portas: {Portas}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Carro
        Carro meuCarro = new Carro("Toyota", "Corolla", 2022, 4);

        // Chamando o método ExibirDetalhes para mostrar as informações do carro
        meuCarro.ExibirDetalhes();
    }
}

