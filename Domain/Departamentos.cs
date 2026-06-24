namespace Domain;
public class Departamentos
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

}
public Interface IDepartamentoRepository
{
    Task<List<Departamentos>> GetAllAsync();
    Task<Departamentos?> GetByIdAsync(int id);
    Task AddAsync(Departamentos departamento);
    Task UpdateAsync(Departamentos departamento);
    Task DeleteAsync(int id);
}