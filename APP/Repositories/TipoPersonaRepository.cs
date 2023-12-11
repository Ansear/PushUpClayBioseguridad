using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class TipoPersonaRepository : GenericRepository<Tipopersona>, ITipoPersona
{
    private readonly PushUpContext _context;

    public TipoPersonaRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}