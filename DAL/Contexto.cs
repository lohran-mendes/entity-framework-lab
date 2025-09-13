using Microsoft.EntityFrameworkCore;

namespace entity_framework_lab.DAL;

public class Contexto: DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }
    public DbSet<Models.Produto> Produtos { get; set; }
}