using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;
using Persistence.Data;

namespace APP.Repository;
public class TipoContactoRepository : GenericRepository<Tipocontacto>, ITipoContacto
{
    private readonly PushUpContext _context;

    public TipoContactoRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}