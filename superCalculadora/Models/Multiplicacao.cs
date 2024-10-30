namespace SuperCalculadora.Modelos
{
    public class Multiplicacao : IOperacao
    {
        public double Calcular(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}
