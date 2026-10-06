using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("Propriedade")]
    public class Propriedade
    {
        [Column("id_propriedade")]
        public int Id { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }

        [Column("tamanho")]
        public double Tamanho { get; set; }

        [Column("endereco")]
        public required string Endereco { get; set; }

        [Column("qtd_animais")]
        public int QtdAnimais { get; set; }

    }
}
