using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace AgroLeite.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("id_usuario")]
        public int Id { get; set; }

        [Column("nome")]
        public required string Nome { get; set; }

        [Column("genero")]
        public required string Genero { get; set; }

        [Column("dt_nascimento")]
        public DateOnly DataNascimento { get; set; }

        [Column("celular")]
        public required string Celular {  get; set; }

        [Column("email")]
        public required string Email { get; set; }

        [Column("cargo")]
        public required string Cargo { get; set; }

        [Column("senha")]
        public required string Senha { get; set; }
    }
}
