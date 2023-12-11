using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;
using Persistence.Data;

namespace APP.Repository;
public class TurnoRepository : GenericRepository<Turno>, ITurno
{
    private readonly PushUpContext _context;

    public TurnoRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}