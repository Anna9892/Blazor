using Microsoft.EntityFrameworkCore;

public class Academy2Context(DbContextOptions<Academy2Context> options) : DbContext(options)
{
    public DbSet<Academy2.Models.Direction> Directions { get; set; } = default!;
    public DbSet<Academy2.Models.Group> Groups { get; set; } = default!;
    public DbSet<Academy2.Models.Student> Students { get; set; } = default!;
    public DbSet<Academy2.Models.Discipline> Disciplines { get; set; } = default!;
    public DbSet<Academy2.Models.Teacher> Teachers { get; set; } = default!;

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        
        modelBuilder.Entity<Academy2.Models.Teacher>()
            .HasKey(t => t.teacher_id);

        modelBuilder.Entity<Academy2.Models.Discipline>()
            .HasKey(d => d.discipline_id);

        modelBuilder.Entity<Academy2.Models.Teacher>()
            .HasMany(t => t.Disciplines)
            .WithMany(d => d.Teacher)
            .UsingEntity<Dictionary<string, object>>(
                "DisciplineTeacher",
                j => j.HasOne<Academy2.Models.Discipline>().WithMany().HasForeignKey("Disciplinesdiscipline_id"),
                j => j.HasOne<Academy2.Models.Teacher>().WithMany().HasForeignKey("Teachersteacher_id")
            );
    }
}
