using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("Piquete")]
    public class Piquete
    {
        [Column("id_piquete")]
        public int Id { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }

        [Column("tamanho")]
        public double Tamanho { get; set; }

        [Column("pastagem")]
        public string? TipoPastagem { get; set; }

        [Column("qtd_animais")]
        public string? QtdAnimais { get; set; }

    }
}
