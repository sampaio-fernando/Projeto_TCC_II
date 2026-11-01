using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("Piquete")]
public class Piquete
{
    [Column("piqueteId")]
    public int PiqueteId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    [Column("tamanho")]
    public double Tamanho { get; set; }

    [Column("pastagem")]
    public string? TipoPastagem { get; set; }

    [Column("qtdAnimais")]
    public string? QtdAnimais { get; set; }

    public int PropriedadeId { get; set; }
    public Propriedade? Propriedade { get; set; }
}
