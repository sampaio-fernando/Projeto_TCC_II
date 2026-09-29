namespace AgroLeite.Models
{
    public class EstoqueInsumo
    {
        public int Id { get; set; }
        public double ValorUnit { get; set; }
        public DateOnly DataValidade { get; set; }
        public double Quantiade { get; set; }
        public DateOnly DataVencimento { get; set; }
        public int QtdParcela { get; set; }
        public string FormaPagamento { get; set; }
    }
}
