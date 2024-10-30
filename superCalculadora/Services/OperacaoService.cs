using SuperCalculadora.Modelos;
using SuperCalculadora.Repositories;

namespace SuperCalculadora.Services
{
    public class OperacaoService
    {
        private readonly OperacaoRepository _operacaoRepository;

        public OperacaoService(OperacaoRepository operacaoRepository)
        {
            _operacaoRepository = operacaoRepository;
        }

        public double ExecutarOperacao(OperacaoDTO operacao)
        {
            return _operacaoRepository.Calcular(operacao);
        }
    }
}
