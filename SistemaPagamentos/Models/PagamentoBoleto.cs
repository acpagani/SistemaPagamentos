namespace SistemaPagamentos.Models
{
    /// <summary>
    /// Representa um pagamento realizado via boleto bancário.
    /// </summary>
    public class PagamentoBoleto : Pagamento
    {
        public string CodigoBarras { get; set; }

        public PagamentoBoleto(decimal valor, string codigoBarras)
            : base(valor)
        {
            CodigoBarras = codigoBarras;
        }

        /// <summary>
        /// Processa o pagamento via boleto e retorna mensagem de confirmação.
        /// </summary>
        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de R$ {Valor:F2} via Boleto " +
                   $"(Cod Barra: {CodigoBarras}) " +
                   $"na data {DataPagamento:dd/MM/yyyy}.";
        }
    }
}
