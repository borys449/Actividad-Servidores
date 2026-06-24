namespace Infrastructure.Data;

using Domain;
using Microsoft.EntityFrameworkCore;
public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }
    public DbSet<Departamentos> Departamentos { get; set; }
}