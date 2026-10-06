using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{

    [Table("Animal")]
    public class Animal
    {
        [Column("id_animal")]
        public int Id { get; set; }

        [Column("identificacao")]
        public required string Identificacao { get; set; }

        [Column("dt_nascimento")]
        public DateOnly DataNascimento { get; set; }

        [Column("peso")]
        public double Peso { get; set; }

        [Column("status")]
        public required string Status { get; set; }
    }
}
