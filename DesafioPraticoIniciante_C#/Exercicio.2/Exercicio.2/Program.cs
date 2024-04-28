namespace Exercicio._2;

internal class Program
{
    static void Main(string[] args)
    {
        var nomeCompleto = new NomeCompleto();  

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        var mensagem = nomeCompleto.Nome(nome: nome, sobrenome: sobrenome);

        Console.WriteLine(mensagem);
    }
}
