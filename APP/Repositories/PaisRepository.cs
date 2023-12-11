using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly PushUpContext _context;

    public PaisRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}