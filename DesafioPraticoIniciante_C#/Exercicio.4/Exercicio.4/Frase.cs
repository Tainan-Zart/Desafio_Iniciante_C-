

namespace Exercicio._4;
 class Frase
{
    public int Contador(string frase)
    {
        var semEspacos = frase.Replace(" ", "");
        return semEspacos.Length;
    }
}
