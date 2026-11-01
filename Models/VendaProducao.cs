using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("VendaProducao")]
public class VendaProducao
{
    public VendaProducao() 
    {
        VendasProducao = new Collection<VendaProducao>();
    }

    [Column("vendaProdId")]
    public int VendaProducaoId { get; set; }

    [Column("observacao")]
    public required string Observacao { get; set; }

    [Column("data")]
    public DateOnly Data { get; set; }

    [Column("desconto")]
    public double ValorDesconto { get; set; }

    [Column("valorTotal")]
    public double ValorTotal { get; set; }

    public int FornecedorId { get; set; }
    public Fornecedor? Fornecedor { get; set; }

    public ICollection<VendaProducao>? VendasProducao { get; set; }
}
