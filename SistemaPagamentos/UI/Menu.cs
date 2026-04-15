namespace SistemaPagamentos.UI
{
    /// <summary>
    /// Classe estática responsável pela exibição da interface do menu principal.
    /// </summary>
    public static class Menu
    {
        public static void ExibirMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***** Sistema de Processamento de Pagamentos *****");
            Console.WriteLine("**********  Escolha a forma de pagamento  **********");
            Console.ResetColor();
            Console.WriteLine("  1 - Cartão");
            Console.WriteLine("  2 - Boleto");
            Console.WriteLine("  3 - Sair");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Escolha uma opção: ");
        }

        public static void ExibirSeparador()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n==================================================");
            Console.ResetColor();
        }
    }
}
