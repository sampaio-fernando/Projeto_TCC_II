using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public required string Nome { get; set; }
    }
}
