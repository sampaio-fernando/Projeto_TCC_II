using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("ProducaoMensal")]
public class ProducaoMensal
{
    public ProducaoMensal()
    {
        ProducoesDiaria = new Collection<ProducaoDiaria>();
    }

    [Column("prodMensalId")]
    public int ProducaoMensalId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    [Column("valorTotal")]
    public double ValorTotal { get; set; }

    [Column("mesReferencia")]
    public required string MesReferencia { get; set; }

    [Column("ano")]
    public int Ano { get; set; }

    [Column("valorLitro")]
    public double ValorLitro { get; set; }

    [Column("litragem")]
    public double Litragem { get; set; }

    [Column("mediaLitros")]
    public double Media { get; set; }  

    public int VendaProducaoId { get; set; }
    public VendaProducao? VendaProducao { get; set; }

    public ICollection<ProducaoDiaria> ProducoesDiaria { get; set; }
}
