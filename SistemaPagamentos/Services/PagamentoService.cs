using SistemaPagamentos.Models;

namespace SistemaPagamentos.Services
{
    /// <summary>
    /// Serviço responsável por coordenar o processamento dos pagamentos.
    /// </summary>
    public class PagamentoService
    {
        /// <summary>
        /// Executa o processamento de um pagamento e exibe o resultado no console.
        /// </summary>
        public void Executar(Pagamento pagamento)
        {
            string resultado = pagamento.ProcessarPagamento();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n✔  " + resultado);
            Console.ResetColor();
        }

        /// <summary>
        /// Lê o valor monetário do console, aceitando vírgula ou ponto como separador decimal.
        /// </summary>
        public decimal LerValor(string mensagem)
        {
            decimal valor;
            while (true)
            {
                Console.Write(mensagem);
                string? entrada = Console.ReadLine();

                // Normaliza tanto "," quanto "." como separador decimal
                string normalizado = entrada?.Replace(",", ".") ?? "";

                if (decimal.TryParse(normalizado,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out valor) && valor > 0)
                {
                    return valor;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Valor inválido. Digite um número positivo (ex: 150,50 ou 150.50).\n");
                Console.ResetColor();
            }
        }
    }
}
