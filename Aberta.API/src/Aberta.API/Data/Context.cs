using AbertaApi.Data.Seed;
using AbertaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AbertaApi.Data;

public class Context : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
}
