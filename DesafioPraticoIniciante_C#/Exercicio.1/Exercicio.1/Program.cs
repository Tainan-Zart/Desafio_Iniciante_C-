namespace Exercicio._1;

internal class Program
{
    static void Main(string[] args)
    {
        var devolveMensagem = new DevolveMensagem();

        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();   

        var mensagem = devolveMensagem.Mensagem(nome);

        Console.WriteLine(mensagem);
    }
}
