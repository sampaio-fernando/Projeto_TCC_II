using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("VendaAnimal")]
    public class VendaAnimal
    {
        [Column("id_venda_animal")]
        public int Id { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }

        [Column("total")]
        public double TotalVenda { get; set; }

        [Column("data_venda")]
        public DateOnly DataVenda { get; set; }

        [Column("forma_receb")]
        public required string FormaRecebimento { get; set; }

        [Column("qtd_parcela")]
        public int QtdParcela { get; set; }

        [Column("dt_recebimento")]
        public DateOnly DataRecebimento { get; set; }

        [Column("desconto")]
        public double ValorDesconto { get; set; }

        [Column("media_peso")]
        public double MediaPeso { get; set; }   
    }
}
