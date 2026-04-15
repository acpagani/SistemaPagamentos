namespace SistemaPagamentos.Models
{
    /// <summary>
    /// Representa um pagamento realizado via cartão de crédito/débito.
    /// </summary>
    public class PagamentoCartao : Pagamento
    {
        public string NumeroCartao { get; set; }

        public PagamentoCartao(decimal valor, string numeroCartao)
            : base(valor)
        {
            NumeroCartao = numeroCartao;
        }

        /// <summary>
        /// Processa o pagamento via cartão e retorna mensagem de confirmação.
        /// </summary>
        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de R$ {Valor:F2} via Cartão " +
                   $"(Número: {NumeroCartao}) " +
                   $"na data {DataPagamento:dd/MM/yyyy}.";
        }
    }
}
