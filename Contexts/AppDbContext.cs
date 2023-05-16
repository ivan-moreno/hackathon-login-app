using Microsoft.EntityFrameworkCore;

namespace HackathonLoginApp.Contexts;

public sealed class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}
