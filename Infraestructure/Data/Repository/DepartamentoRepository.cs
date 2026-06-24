using Domain;
namespace Infrastructure.Data.Repository;


public class DepartamentoRepository : IDepartamentoRepository
{
    public DepartamentoRepository(ApplicationContext context)
    {
        _context = context;
    }
    public async Task AddAsync(Departamentos departamento)
    {
        _context.Departamentos.Add(departamento);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var departamento = await _context.Departamentos.FindAsync(id);
        if (departamento != null)
        {
            _context.Departamentos.Remove(departamento);
            await _context.SaveChangesAsync();
        }
    }
    public async Task<List<Departamentos>> GetAllAsync()
    {
        return await _context.Departamentos.ToListAsync();
    }
    public async Task<Departamentos?> GetByIdAsync(int id)
    {
        return await _context.Departamentos.FindAsync(id);
    }
    public async Task UpdateAsync(Departamentos departamento)
    {
        _context.Departamentos.Update(departamento);
        await _context.SaveChangesAsync();
    }
}