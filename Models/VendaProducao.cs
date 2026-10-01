namespace AgroLeite.Models
{
    public class VendaProducao
    {
        public int Id { get; set; }
        public string Observacao { get; set; }
        public DateOnly Data { get; set; }
        public double ValorDesconto { get; set; }
        public double ValorTotal { get; set; }

    }
}
