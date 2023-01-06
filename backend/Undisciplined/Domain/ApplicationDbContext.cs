using Microsoft.EntityFrameworkCore;

namespace Undisciplined.Domain;

public class ApplicationDbContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Objective> Objectives { get; set; }
    public DbSet<CompletableObjective> CompletableObjectives { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Task>()
            .Property(t => t.ExpiresAfter)
            .HasConversion(
                e => e.TotalHours,
                e => TimeSpan.FromHours(e));
    }
}