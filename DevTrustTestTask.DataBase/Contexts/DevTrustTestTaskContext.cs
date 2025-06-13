using DevTrustTestTask.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevTrustTestTask.DataBase.Contexts;

public sealed class DevTrustTestTaskContext(DbContextOptions<DevTrustTestTaskContext> options) : DbContext(options)
{
    public DbSet<Person> People { get; set; }

    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
    }
}
