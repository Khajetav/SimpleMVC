using SimpleMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleMVC.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Person> People { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // sensitive info in a string, locate it in a separate file if hosted publiclly
        optionsBuilder.UseSqlServer(@"Server=host.docker.internal,1433;Database=SimpleMVC;User ID=sa;Password=yourStrong(!)Password;");

    }
}