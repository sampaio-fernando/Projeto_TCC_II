using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("ProducaoDiaria")]
    public class ProducaoDiaria
    {
        [Column("id_producao_dia")]
        public int Id { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }

        [Column("media")]
        public double MediaAnimal { get; set; }

        [Column("dt_hr_inicio")]
        public DateTime DataHoraInicio { get; set; }

        [Column("qtd_vacas")]
        public int QtdVacas { get; set; }

        [Column("qtd_litros")]
        public double QtdLitros { get; set; }

        [Column("observacao")]
        public string? Observacao { get; set; }
    }
}
