namespace SuperCalculadora.Modelos
{
    public class OperacaoDTO
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public string Operacao { get; set; }

        public OperacaoDTO(double numero1, double numero2, string operacao)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            Operacao = operacao;
        }

        public OperacaoDTO() { }
    }
}
