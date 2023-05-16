using Microsoft.EntityFrameworkCore;

namespace HackathonLoginApp.Contexts;

/// <summary>
/// Allows integrated Database access via Entity Framework.
/// </summary>
public sealed class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}
