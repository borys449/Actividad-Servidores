namespace Application.Departamentos.Queries;

public interface IDepartamentoGetAll
{
    Task<List<DepartamentoGetAllDto>> Execute();
}
public class DepartamentoGetAll : IDepartamentoGetAll
{
    private readonly IDepartamentoRepository _repositoryDepartamentos;

    public DepartamentoGetAll(IDepartamentoRepository repositoryDepartamentos)
    {
        _repositoryDepartamentos = repositoryDepartamentos;
    }

    public async Task<List<DepartamentoGetAllDto>> Execute()
    {
        var departamentos = await _repositoryDepartamentos.GetAllAsync();
        return departamentos.Select(d => new DepartamentoGetAllDto(d.Id, d.Nombre)).ToList();
    }
}

public record DepartamentoGetAllDto(int Id, string Nombre);
