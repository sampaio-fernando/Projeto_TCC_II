using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("Cidade")]
public class Cidade
{
    public Cidade()
    {
        Enderecos = new Collection<Endereco>();
    }

    [Column("cidadeId")]
    public int CidadeId { get; set; }

    [Column("nome")]
    public required string Nome { get; set; }

    public int EstadoId { get; set; }
    public Estado? Estado { get; set; }

    public ICollection<Endereco>? Enderecos { get; set; }
}
