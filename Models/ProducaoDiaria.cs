using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("ProducaoDiaria")]
public class ProducaoDiaria
{
    [Column("prodDiariaId")]
    public int ProducaoDiariaId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    [Column("media")]
    public double MediaAnimal { get; set; }

    [Column("dtHrInicio")]
    public DateTime DataHoraInicio { get; set; }

    [Column("qtdVacas")]
    public int QtdVacas { get; set; }

    [Column("qtdLitros")]
    public double QtdLitros { get; set; }

    [Column("observacao")]
    public string? Observacao { get; set; }

    public int ProducaoMensalId { get; set; }
    public ProducaoMensal? ProducaoMensal { get; set; }
}
