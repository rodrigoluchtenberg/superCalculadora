using System.Data;

namespace SuperCalculadora.Modelos
{
    public class Divisao : IOperacao
    {
        public double Calcular(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                throw new DivideByZeroException("Não pode dividir por  zero");
            }
            return numero1 / numero2;
        }
    }
}
