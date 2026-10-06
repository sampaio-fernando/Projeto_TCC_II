using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("ContasPagar")]
    public class ContasPagar
    {
        [Column("id_contas_pagar")]
        public int Id { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }

        [Column("qtd_parcela")]
        public int QtdParcela { get; set; }

        [Column("dt_emissao")]
        public DateOnly DataEmissao { get; set; }

        [Column("dt_vencimento")]
        public DateOnly DataVencimento { get; set; }

        [Column("valor")]
        public double Valor {  get; set; }

        [Column("status")]
        public bool Status {  get; set; }

        [Column("categoria")]
        public required string Categoria { get; set; }

        [Column("forma_pag")]
        public string? FormaPagamento { get; set; }

        [Column("observacao")]
        public string? Observacao { get; set; }
    }
}
