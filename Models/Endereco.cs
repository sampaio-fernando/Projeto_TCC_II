using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace AgroLeite.Models;

[Table("Endereco")]
public class Endereco
{
    public Endereco() 
    {
        Fornecedores = new Collection<Fornecedor>();
    }

    [Column("enderecoId")]
    public int EnderecoId { get; set; }

    [Column("cep")]
    public required string Cep { get; set; }

    [Column("logradouro")]
    public required string Logradouro { get; set; }

    [Column("bairro")]
    public required string Bairro { get; set; }

    [Column("numero")]
    public int Numero { get; set; }

    [Column("complemen")]
    public string? Complemento { get; set; }

    public int CidadeId { get; set; }
    public Cidade Cidade { get; set; }

    public ICollection<Fornecedor>? Fornecedores { get; set; }
}
