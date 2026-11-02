using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("EstoqueInsumo")]
public class EstoqueInsumo
{
    [Column("estoqueInsumoId")]
    public int EstoqueInsumoId { get; set; }

    [Column("valor")]
    public double ValorUnit { get; set; }

    [Column("dtValidade")]
    public DateOnly DataValidade { get; set; }

    [Column("qtd")]
    public double Quantidade { get; set; }

    [Column("dtVencimento")]
    public DateOnly DataVencimento { get; set; }

    [Column("qtdParcela")]
    public int QtdParcela { get; set; }

    [Column("formaPag")]
    public required string FormaPagamento { get; set; }

    public int InsumoId { get; set; }
    public Insumo? Insumo { get; set; }

    public int FornecedorId { get; set; }
    public Fornecedor? Fornecedor { get; set; }

    public int PropriedadeId { get; set; }
    public Propriedade? Propriedade { get; set; }
}
