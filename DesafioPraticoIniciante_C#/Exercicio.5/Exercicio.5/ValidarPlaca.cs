

namespace Exercicio._5;
internal class ValidarPlaca
{
    public bool placaCarro(string placaDigitada)
    {
       if (placaDigitada.Length != 7)
        {
            return false;
        }

       for(int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placaDigitada[i]))
            {
                return false;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placaDigitada[i]))
            {
                return false;
            }
        }

        return true;    


    }

}
