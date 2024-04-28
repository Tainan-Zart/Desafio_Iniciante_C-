
namespace Exercicio._3;
internal class Calculadora
{
    public double Soma(double numero1, double numero2)
    {
        return numero1 + numero2;
    }
    public double Subtracao(double numero1, double numero2)
    {
        return numero1 - numero2;
    }

    public double Multiplicacao(double numero1, double numero2)
    {
        return numero1 * numero2;
    }

    public double Divisao(double numero1, double numero2)
    {
        if (numero2 != 0)
            return numero1 / numero2;
        return 0;
        
    }

    public double Media(double numero1, double numero2)
    {
        return (numero1 + numero2) /2;
    }
}
