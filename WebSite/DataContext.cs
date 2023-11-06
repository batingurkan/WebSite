using Microsoft.EntityFrameworkCore;
using WebSite.Entity;
namespace WebSite;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Sayfa> Sayfa { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Communication> Communications { get; set; }
    public DbSet<About> Abouts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}