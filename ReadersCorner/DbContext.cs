using Microsoft.EntityFrameworkCore;
using ReadersCorner.Models; // Make sure to use your model's namespace

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } // Users table

    // Add DbSets for other entities
}
