using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
{
    private readonly PushUpContext _context;

    public DepartamentoRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}