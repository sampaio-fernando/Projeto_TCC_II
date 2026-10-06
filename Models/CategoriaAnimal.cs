using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("CategAnimal")]
    public class CategoriaAnimal
    {
        [Column("id_categ_animal")]
        public int Id { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }
    }
}

