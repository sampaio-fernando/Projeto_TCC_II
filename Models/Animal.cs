namespace AgroLeite.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Identificacao { get; set; }
        public DateOnly DataNascimento { get; set; }
        public double Peso { get; set; }
        public string Status { get; set; }
    }
}
