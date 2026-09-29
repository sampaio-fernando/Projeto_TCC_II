namespace AgroLeite.Models
{
    public class ContasPagar
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int QtdParcela { get; set; }
        public DateOnly DataEmissao { get; set; }
        public DateOnly DataVencimento { get; set; }
        public double Valor {  get; set; }
        public bool Status {  get; set; }
        public string Categoria { get; set; }
        public string FormaPagamento { get; set; }

        public string Observacao { get; set; }
    }
}
