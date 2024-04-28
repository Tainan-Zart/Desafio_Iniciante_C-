namespace Exercicio._6;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a data de hoje");
        string Digitada = Console.ReadLine();

        var dataHora = new DataHora();

        var formatoCompleto = dataHora.DataCompleta(Digitada);
        var formatoData = dataHora.FormatoData(Digitada);
        var formatoHora = dataHora.FormatoHora(Digitada);
        var formatoMesExtenso = dataHora.MesExtenso(Digitada);




        Console.WriteLine("Formato completo: " + formatoCompleto);
        Console.WriteLine("Apenas a data: " + formatoData);
        Console.WriteLine("Apenas a hora: " + formatoHora);
        Console.WriteLine("Data com o mês por extenso: " + formatoMesExtenso);
    }
}
