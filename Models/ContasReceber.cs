using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("ContasReceber")]
public class ContasReceber
{
    [Column("contasReceberId")]
    public int ContasReceberId { get; set; }

    [Column("valor")]
    public double Valor { get; set; }

    [Column("status")]
    public bool Status { get; set; }

    [Column("dtRecebimento")]
    public DateOnly DataRecebimento { get; set; }

    [Column("parcela")]
    public string? Parcela {  get; set; }

    public int VendaAnimalId { get; set; }
    public VendaAnimal? VendaAnimal { get; set; }
}
