using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Column("id_endereco")]
        public int Id { get; set; }

        [Column("cep")]
        public required string Cep { get; set; }

        [Column("logradouro")]
        public required string Logradouro { get; set; }

        [Column("bairro")]
        public required string Bairro { get; set; }

        [Column("numero")]
        public int Numero { get; set; }

        [Column("complemento")]
        public string? Complemento { get; set; }
    }
}
