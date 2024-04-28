namespace Exercicio._3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite um segundo numero");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        var calculadora = new Calculadora();

        var soma = calculadora.Soma(numero1, numero2);
        var sub = calculadora.Subtracao(numero1, numero2);
        var multi = calculadora.Multiplicacao(numero1, numero2);
        var div = calculadora.Divisao(numero1, numero2);
        var media = calculadora.Media(numero1, numero2);

        Console.WriteLine($"Soma: {soma} ");
        Console.WriteLine($"Subtração: {sub} ");
        Console.WriteLine($"Multiplicação: {multi} ");
        Console.WriteLine($"Divisão: {div} ");
        Console.WriteLine($"Media: {media} ");
    }
}
