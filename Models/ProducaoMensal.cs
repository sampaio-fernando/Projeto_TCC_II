using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{

    [Table("ProducaoMensal")]
    public class ProducaoMensal
    {
        [Column("id_producao_mensal")]
        public int Id { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }

        [Column("valor_total")]
        public double ValorTotal { get; set; }

        [Column("mes_referencia")]
        public required string MesReferencia { get; set; }

        [Column("ano")]
        public int Ano { get; set; }

        [Column("valor_litro")]
        public double ValorLitro { get; set; }

        [Column("litragem")]
        public double Litragem { get; set; }

        [Column("media_litros")]
        public double Media { get; set; }  

    }
}
