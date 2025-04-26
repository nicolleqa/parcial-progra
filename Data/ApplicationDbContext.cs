using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using parcial.Models;

namespace parcial.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Players> Players { get; set; } = default!;
    public DbSet<Teams> Teams { get; set; } = default!;
    public DbSet<PlayersTeams> PlayersTeams { get; set; } = default!;
}
