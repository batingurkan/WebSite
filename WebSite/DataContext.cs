using Microsoft.EntityFrameworkCore;
using WebSite.Entity;
namespace WebSite;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Page> Page { get; set; }
    public DbSet<Admin> Admin { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Company> Company { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}