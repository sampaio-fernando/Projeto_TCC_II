using System.Globalization;

namespace AgroLeite.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Celular {  get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }
    }
}
