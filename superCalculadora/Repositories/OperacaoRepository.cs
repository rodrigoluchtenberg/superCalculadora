using SuperCalculadora.Modelos;

namespace SuperCalculadora.Repositories
{
    public class OperacaoRepository
    {
        public double Calcular(OperacaoDTO operacao)
        {
            IOperacao operacaoRealizada;

            switch (operacao.Operacao.ToLower())
            {
                case "soma":
                    operacaoRealizada = new Soma();
                    break;
                case "subtracao":
                    operacaoRealizada = new Subtracao();
                    break;
                case "multiplicacao":
                    operacaoRealizada = new Multiplicacao();
                    break;
                case "divisao":
                    operacaoRealizada = new Divisao();
                    break;
                default:
                    throw new ArgumentException("Operação inválida");
            }

            return operacaoRealizada.Calcular(operacao.Numero1, operacao.Numero2);
        }
    }
}
