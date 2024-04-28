using System.Globalization;

namespace Exercicio._5;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite A placa de um carro");
        string placaCarro = Console.ReadLine();

        var validarPlaca = new ValidarPlaca();

        bool placaValida = validarPlaca.placaCarro(placaCarro);

        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
    }
}
