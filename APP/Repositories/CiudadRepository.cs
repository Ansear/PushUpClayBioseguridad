using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;
using Persistence.Data;

namespace APP.Repository;
public class CiudadRepository : GenericRepository<Ciudad>, ICiudad
{
    private readonly PushUpContext _context;

    public CiudadRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}