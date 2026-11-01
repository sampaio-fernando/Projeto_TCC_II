using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroLeite.Models;

[Table("Estado")]
public class Estado
{
    public Estado ()
    {
        Cidades = new Collection<Cidade>();
    }    

    [Column("estadoId")]
    public int EstadoId { get; set; }

    [Column("nome")]
    public required string Nome { get; set; }

    [Column("uf")]
    public required string Uf { get; set; }

    public ICollection<Cidade>? Cidades { get; set; }
}
