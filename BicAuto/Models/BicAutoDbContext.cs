using Microsoft.EntityFrameworkCore;

namespace BicAuto.Models;

public class BicAutoDbContext : DbContext
{
    public BicAutoDbContext(DbContextOptions<BicAutoDbContext>
        options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Auto> Autos { get; set; }=null!;   
}

