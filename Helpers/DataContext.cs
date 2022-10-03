namespace Auth_NET6_Test.Helpers;

using Microsoft.EntityFrameworkCore;
using Auth_NET6_Test.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server database
        options.UseSqlServer(Configuration.GetConnectionString("Auth-NET6-Test"));
    }

    public DbSet<User> Users { get; set; }
}