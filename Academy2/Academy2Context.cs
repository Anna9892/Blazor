using Microsoft.EntityFrameworkCore;

public class Academy2Context(DbContextOptions<Academy2Context> options) : DbContext(options)
{
    public DbSet<Academy2.Models.Direction> Directions { get; set; } = default!;
}
