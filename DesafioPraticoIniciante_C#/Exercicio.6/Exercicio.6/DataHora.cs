

namespace Exercicio._6;
 class DataHora
{
    DateTime dataAtual = DateTime.Now;

    public string DataCompleta(string diaHora)
    {
       
        string formatoCompleto = dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss");
        
          return formatoCompleto;
    }  

    public string FormatoData(string diaHora)
    {
        
        string formatoData = dataAtual.ToString("dd/MM/yyyy");

        return formatoData;

    }

    public string MesExtenso(string diaHora)
    {
        
        string formatoMesExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy");

        return formatoMesExtenso;

    }

    public string FormatoHora(string diaHora)
    {
        
        string formatoHora = dataAtual.ToString("HH:mm:ss");

        return formatoHora;

    }



}
