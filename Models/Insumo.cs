using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("Insumo")]
public class Insumo
{
    [Column("insumoId")]
    public int InsumoId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    [Column("undMedida")]
    public required string UndMedida { get; set; }

    [Column("categoria")]
    public required string Categoria { get; set; }

    public int CategoriaInsumoId { get; set; }
    public CategoriaInsumo? CategoriaInsumo { get; set; }

}
