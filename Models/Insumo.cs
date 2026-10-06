using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("Insumo")]
    public class Insumo
    {
        [Column("id_insumo")]
        public int Id { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }

        [Column("und_medida")]
        public required string UndMedida { get; set; }

        [Column("categoria")]
        public required string Categoria { get; set; }

    }
}
