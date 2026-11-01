using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace AgroLeite.Models;

[Table("CategInsumo")]
public class CategoriaInsumo
{
    public CategoriaInsumo()
    {
        Insumos = new Collection<Insumo>();
    }

    [Column("categInsumoId")]
    public int CategoriaInsumoId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    public ICollection<Insumo>? Insumos { get; set; }
}
