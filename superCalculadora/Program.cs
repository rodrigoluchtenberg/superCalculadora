using System;
using SuperCalculadora.Modelos;
using SuperCalculadora.Repositories;
using SuperCalculadora.Services;

class Program
{
    static void Main(string[] args)
    {
        var repository = new OperacaoRepository();
        var service = new OperacaoService(repository);

        Console.WriteLine("Bem-vindo à Super Calculadora!");

        while (true)
        {
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");
            Console.Write("Opção: ");
            string escolha = Console.ReadLine();

            if (escolha == "5")
                break;

            try
            {
                Console.Write("Digite o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                string operacao = escolha switch
                {
                    "1" => "soma",
                    "2" => "subtracao",
                    "3" => "multiplicacao",
                    "4" => "divisao",
                    _ => throw new ArgumentException("Opção inválida")
                };

                var operacaoDTO = new OperacaoDTO(numero1, numero2, operacao);
                double resultado = service.ExecutarOperacao(operacaoDTO);

                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        Console.WriteLine("Obrigado por usar a Super Calculadora!");
    }
}
