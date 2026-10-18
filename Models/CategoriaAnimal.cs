using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("CategoriasAnimal")]
public class CategoriaAnimal
{
    [Column("id_categ_animal")]
    public int CategoriaAnimalId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }
}

