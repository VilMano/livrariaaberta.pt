using AbertaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AbertaApi.Data;

public class Context(string connectionString = "Host=db;Port=3306;Database=Aberta;Username=root;Password=P4sSw0+rd@") : DbContext(GetOptions(connectionString))
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Tag> Tags { get; set; }

    private static DbContextOptions<Context> GetOptions(string connectionString)
    {
        return new DbContextOptionsBuilder<Context>().UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString)
        ).Options;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasMany(e => e.TagsList)
            .WithMany(e => e.Books);
    }
}