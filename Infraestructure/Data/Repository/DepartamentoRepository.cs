using Domain;
namespace Infrastructure.Data.Repository;


public class DepartamentoRepository : IDepartamentoRepository
{
    public Task AddAsync(Departamentos departamento)
    {
        throw new NotImplementedException();
    }
    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
    public async Task<List<Departamentos>> GetAllAsync()
    {
        return await Task.FromResult
        (new List<Departamentos>
        {
            new () { Id = 1, Nombre = "Recursos Humanos" },
            new () { Id = 2, Nombre = "Finanzas" },
            new () { Id = 3, Nombre = "Tecnología" }
        });
    }
    public Task<Departamentos?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}