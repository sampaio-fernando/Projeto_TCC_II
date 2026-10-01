namespace AgroLeite.Models
{
    public class VendaAnimais
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double TotalVenda { get; set; }
        public DateOnly DataVenda { get; set; }
        public string FormaRecebimento { get; set; }
        public int QtdParcela { get; set; }
        public DateOnly DataRecebimento { get; set; }
        public double ValorDesconto { get; set; }
        public double MediaPeso { get; set; }   
    }
}
