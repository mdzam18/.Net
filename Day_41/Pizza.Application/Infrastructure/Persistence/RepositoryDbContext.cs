using Microsoft.EntityFrameworkCore;
using Pizza.Domain.Entity;

public sealed class RepositoryDbContext : DbContext
{
    public RepositoryDbContext(DbContextOptions options) : base(options) { }

    public DbSet<PizzaEntity> Pizzas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDbContext).Assembly);
    }
}