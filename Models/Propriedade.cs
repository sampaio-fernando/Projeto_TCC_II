using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("Propriedade")]
public class Propriedade
{
    public Propriedade()
    {
        Animais = new Collection<Animal>();
        Piquetes = new Collection<Piquete>();
    }

    [Column("propriedadeId")]
    public int PropriedadeId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    [Column("tamanho")]
    public double Tamanho { get; set; }

    [Column("endereco")]
    public required string Endereco { get; set; }

    [Column("qtdAnimais")]
    public int QtdAnimais { get; set; }

    public ICollection<Animal>? Animais { get; set; }
    public ICollection<Piquete>? Piquetes { get; set; }

}
