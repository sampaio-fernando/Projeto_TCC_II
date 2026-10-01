namespace AgroLeite.Models
{
    public class ContasReceber
    {
        public int Id { get; set; }
        public double ValorRecebido { get; set; }
        public bool Status { get; set; }
        public DateOnly DataRecebimento { get; set; }
        public string Parcela {  get; set; }
    }
}
