namespace SistemaPagamentos.Models
{
    /// <summary>
    /// Classe base abstrata que representa um pagamento genérico.
    /// </summary>
    public abstract class Pagamento
    {
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        protected Pagamento(decimal valor)
        {
            Valor = valor;
            DataPagamento = DateTime.Now;
        }

        /// <summary>
        /// Método abstrato que deve ser implementado por cada tipo de pagamento.
        /// </summary>
        public abstract string ProcessarPagamento();
    }
}
