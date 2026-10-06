using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("ContasReceber")]
    public class ContasReceber
    {
        [Column("id_contas_receber")]
        public int Id { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("dt_recebimento")]
        public DateOnly DataRecebimento { get; set; }

        [Column("parcela")]
        public string? Parcela {  get; set; }
    }
}
