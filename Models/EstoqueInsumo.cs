using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("EstoqueInsumo")]
    public class EstoqueInsumo
    {
        [Column("id_estoque_insumo")]
        public int Id { get; set; }

        [Column("valor")]
        public double ValorUnit { get; set; }

        [Column("dt_validade")]
        public DateOnly DataValidade { get; set; }

        [Column("quantidade")]
        public double Quantidade { get; set; }

        [Column("dt_vencimento")]
        public DateOnly DataVencimento { get; set; }

        [Column("qtd_parcela")]
        public int QtdParcela { get; set; }

        [Column("forma_pag")]
        public required string FormaPagamento { get; set; }
    }
}
