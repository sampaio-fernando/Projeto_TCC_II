using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("VendaProducao")]
    public class VendaProducao
    {
        [Column("id_venda_producao")]
        public int Id { get; set; }

        [Column("observacao")]
        public required string Observacao { get; set; }

        [Column("data")]
        public DateOnly Data { get; set; }

        [Column("desconto")]
        public double ValorDesconto { get; set; }

        [Column("valor_total")]
        public double ValorTotal { get; set; }

    }
}
