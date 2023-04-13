namespace BrunsonHome.API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    public DbSet<Horse> Horses { get; set; }
    public DbSet<FootTrim> FootTrims { get; set; }
}