using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class EstadoRepository : GenericRepository<Estado>, IEstado
{
    private readonly PushUpContext _context;

    public EstadoRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}