using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("Animais")]
public class Animal
{
    [Column("animalId")]
    public int AnimalId { get; set; }

    [Column("identificacao")]
    public required string Identificacao { get; set; }

    [Column("dtNascimento")]
    public DateOnly DataNascimento { get; set; }

    [Column("peso")]
    public double Peso { get; set; }

    [Column("status")]
    public required string Status { get; set; }

    public int CategoriaId { get; set; }
    public CategoriaAnimal? Categoria { get; set; }

    public int PropriedadeId { get; set; }
    public Propriedade? Propriedade { get; set; }

    public int VendaAnimalId { get; set; }
    public VendaAnimal? VendaAnimal { get; set; }
}
