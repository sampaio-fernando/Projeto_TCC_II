namespace AgroLeite.Models
{
    public class ProducaoDiaria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double MediaAnimal { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public int QtdVacas { get; set; }
        public double QtdLitros { get; set; }
        public string? Observacao { get; set; }
    }
}
