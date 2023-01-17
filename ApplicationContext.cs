using Microsoft.EntityFrameworkCore;
using StudiaProgramm;
using System;

public class ApplicationContext : DbContext
{
    public static ApplicationContext _context;
    public static ApplicationContext GetContext()
    {
        if (_context == null)
            _context = new ApplicationContext();

        return _context;

    }

    public DbSet<User> user { get; set; } = null!;
    public DbSet<products> Products { get; set; } = null!;
    public DbSet<Role> role { get; set; } = null!;
    public DbSet<Client> client { get; set; } = null!;


    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=185.26.122.80;user=host1849318_ishenko;password=qwerty123!;database=host1849318_ishenko;",
        new MySqlServerVersion(new Version(8, 0, 25)));
    }
}
