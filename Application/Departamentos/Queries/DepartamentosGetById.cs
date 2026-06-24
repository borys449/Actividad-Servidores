namespace Application.Departamentos.Queries;
using Domain;

public interface IDepartamentoGetById
{
    Task<List<DepartamentoGetByIdDto>> Execute();
}
public class DepartamentoGetById : IDepartamentoGetById
{
    private readonly IDepartamentoRepository _repositoryDepartamentos;

    public DepartamentoGetById(IDepartamentoRepository repositoryDepartamentos)
    {
        _repositoryDepartamentos = repositoryDepartamentos;
    }

    public async Task<List<DepartamentoGetByIdDto>> Execute()
    {
        var departamentos = await _repositoryDepartamentos.GetAllAsync();
        return departamentos.Select(d => new DepartamentoGetByIdDto(d.Id, d.Nombre)).ToList();
    }
}

public record DepartamentoGetByIdDto(int Id, string Nombre);
