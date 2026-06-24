using Infrastructure.Data.Repository;
using Ifrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure;
public static class InyeccionDedepndencias
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        var connectionString = services
            .BuilderServicesProvider()
            .GetRequiredService<IConfiguration>()
            .GetConnectionString("abnbdb");
        services.AddDbContext<ApplicationContext>(options =>{options.UseNpgsql(connectionString);});
        services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
    }
}