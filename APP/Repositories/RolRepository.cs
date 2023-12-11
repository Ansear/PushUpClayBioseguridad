using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class RolRepository : GenericRepository<Rol>, IRol
{
    private readonly PushUpContext _context;

    public RolRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}