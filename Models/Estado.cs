using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("id_estado")]
        public int Id { get; set; }

        [Column("nome")]
        public required string Nome { get; set; }

        [Column("uf")]
        public required string Uf { get; set; }
    }
}
