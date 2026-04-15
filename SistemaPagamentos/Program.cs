using SistemaPagamentos.Models;
using SistemaPagamentos.Services;
using SistemaPagamentos.UI;

namespace SistemaPagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoService = new PagamentoService();
            string opcao;

            do
            {
                Menu.ExibirMenu();
                opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        ProcessarCartao(pagamentoService);
                        break;

                    case "2":
                        ProcessarBoleto(pagamentoService);
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nEncerrando o sistema. Até logo!");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção inválida. Por favor, escolha 1, 2 ou 3.");
                        Console.ResetColor();
                        break;
                }

                if (opcao != "3")
                    Menu.ExibirSeparador();

            } while (opcao != "3");
        }

        static void ProcessarCartao(PagamentoService service)
        {
            Console.WriteLine("\n--- Pagamento com Cartão ---");

            decimal valor = service.LerValor("Informe o valor do pagamento: R$ ");

            Console.Write("Informe o número do cartão: ");
            string numeroCartao = Console.ReadLine() ?? "";

            var pagamento = new PagamentoCartao(valor, numeroCartao);
            service.Executar(pagamento);
        }

        static void ProcessarBoleto(PagamentoService service)
        {
            Console.WriteLine("\n--- Pagamento com Boleto ---");

            decimal valor = service.LerValor("Informe o valor do pagamento: R$ ");

            Console.Write("Informe o código de barras: ");
            string codigoBarras = Console.ReadLine() ?? "";

            var pagamento = new PagamentoBoleto(valor, codigoBarras);
            service.Executar(pagamento);
        }
    }
}
