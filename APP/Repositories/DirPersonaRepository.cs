using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class DirPersonaRepository : GenericRepository<Dirpersona>, IDirPersona
{
    private readonly PushUpContext _context;

    public DirPersonaRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}