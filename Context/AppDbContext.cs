using AgroLeite.Models;
using Microsoft.EntityFrameworkCore;

namespace AgroLeite.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options ): base( options )   
    {
        
    }

    public DbSet<Animal> Animais { get; set; }
    public DbSet<CategoriaAnimal> CategoriasAnimal { get; set; }
    public DbSet<CategoriaInsumo> CategoriasInsumo { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<ContasPagar> ContasPagar { get; set; }
    public DbSet<ContasReceber> ContasReceber { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<EstoqueInsumo> EstoquesInsumos { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<Insumo> Insumos { get; set; }
    public DbSet<Piquete> Piquetes { get; set; }
    public DbSet<ProducaoDiaria> ProducoesDiarias { get; set; }
    public DbSet<ProducaoMensal> ProducoesMensais { get; set; }
    public DbSet<Propriedade> Propriedades { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<VendaAnimal> VendasAnimais { get; set; }
    public DbSet<VendaProducao> VendasProducoes { get; set; }
}