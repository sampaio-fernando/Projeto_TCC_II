using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("Cidade")]
public class Cidade
{
    [Column("cidadeId")]
    public int CidadeId { get; set; }

    [Column("nome")]
    public required string Nome { get; set; }

    public int EstadoId { get; set; }
    public Estado? Estado { get; set; }
}
