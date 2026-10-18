using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("CategInsumo")]
public class CategoriaInsumo
{
    [Column("id_categ_insumo")]
    public int CategoriaInsumoId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }
}
