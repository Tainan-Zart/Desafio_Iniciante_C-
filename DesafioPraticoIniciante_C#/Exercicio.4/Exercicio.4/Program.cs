namespace Exercicio._4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um frase");
        string fraseUsuario = Console.ReadLine();

        var frase = new Frase();


        var resultado = frase.Contador(fraseUsuario);

        Console.WriteLine(resultado);
        
    }
}
