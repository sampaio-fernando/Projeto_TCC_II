using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("VendaAnimal")]
public class VendaAnimal
{
    public VendaAnimal()
    {
        Animais = new Collection<Animal>();
        ContasReceb = new Collection<ContasReceber>();
    }

    [Column("vendaAnimalId")]
    public int VendaAnimalId { get; set; }

    [Column("descricao")]
    public required string Descricao { get; set; }

    [Column("totalVenda")]
    public double TotalVenda { get; set; }

    [Column("dataVenda")]
    public DateOnly DataVenda { get; set; }

    [Column("formaReceb")]
    public required string FormaRecebimento { get; set; }

    [Column("qtdParcela")]
    public int QtdParcela { get; set; }

    [Column("dtRecebimento")]
    public DateOnly DataRecebimento { get; set; }

    [Column("desconto")]
    public double ValorDesconto { get; set; }

    [Column("mediaPeso")]
    public double MediaPeso { get; set; }
    
    public int FornecedorId { get; set; }
    public Fornecedor Fornecedor { get; set; }

    public ICollection<Animal>? Animais { get; set; }
    public ICollection<ContasReceber>? ContasReceb { get; set; }

}
