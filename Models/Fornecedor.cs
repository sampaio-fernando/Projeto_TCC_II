using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("Fornecedor")]
public class Fornecedor
{
    public Fornecedor()
    {
        VendasAnimal = new Collection<VendaAnimal>();
        VendasProducao = new Collection<VendaProducao>();
        ContasPagar = new Collection<ContasPagar>();
        EstoquesInsumo = new Collection<EstoqueInsumo>();
    }

    [Column("fornecedorId")]
    public int FornecedorId { get; set; }

    [Column("razaoSocial")]
    public required string RazaoSocial { get; set; }

    [Column("fantasia")]
    public required string Fantasia {  get; set; }

    [Column("personalidade")]
    public required string Personalidade { get; set; }

    [Column("cnpjCpf")]
    public required string CnpjCpf { get; set; }

    [Column("celular")]
    public string? Celular {  get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("telefone")]
    public string? Telefone { get; set; }

    public int EnderecoId { get; set; }
    public Endereco Endereco { get; set; }

    public ICollection<VendaAnimal>? VendasAnimal { get; set; }
    public ICollection<VendaProducao>? VendasProducao { get; set; }
    public ICollection<ContasPagar>? ContasPagar { get; set; }
    public ICollection<EstoqueInsumo>? EstoquesInsumo { get; set; }
}
