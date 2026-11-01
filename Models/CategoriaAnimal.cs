using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("CategAnimal")]
public class CategoriaAnimal
{
    //inicializando a colecao de animais
    public CategoriaAnimal()
    {
        Animais = new Collection<Animal>();
    }

    [Column("categAnimalId")]
    public int CategAnimalId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    public ICollection<Animal>? Animais { get; set; }
}

