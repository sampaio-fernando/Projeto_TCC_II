using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("ContasPagar")]
public class ContasPagar
{
    [Column("contasPagarId")]
    public int ContasPagarId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    [Column("qtdParcela")]
    public int QtdParcela { get; set; }

    [Column("dtEmissao")]
    public DateOnly DataEmissao { get; set; }

    [Column("dtVencimento")]
    public DateOnly DataVencimento { get; set; }

    [Column("valor")]
    public double Valor {  get; set; }

    [Column("status")]
    public bool Status {  get; set; }

    [Column("categoria")]
    public required string Categoria { get; set; }

    [Column("formaPagam")]
    public string? FormaPagamento { get; set; }

    [Column("observacao")]
    public string? Observacao { get; set; }

    public int FornecedorId { get; set; }
    public Fornecedor? Fornecedor { get; set; }
}
