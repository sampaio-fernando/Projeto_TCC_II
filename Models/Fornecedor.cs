using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("id_fornecedor")]
        public int Id { get; set; }

        [Column("razao_social")]
        public required string RazaoSocial { get; set; }

        [Column("fantasia")]
        public required string Fantasia {  get; set; }

        [Column("personalidade")]
        public required string Personalidade { get; set; }

        [Column("cnpj_cpf")]
        public required string CnpjCpf { get; set; }

        [Column("celular")]
        public string? Celular {  get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("telefone")]
        public string? Telefone { get; set; }
    }
}
