using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class ProgramacionRepository : GenericRepository<Programacion>, IProgramacion
{
    private readonly PushUpContext _context;

    public ProgramacionRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}