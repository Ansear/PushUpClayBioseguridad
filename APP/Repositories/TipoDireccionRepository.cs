using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;
using Persistence.Data;

namespace APP.Repository;
public class TipoDireccionRepository : GenericRepository<Tipodireccion>, ITipoDireccion
{
    private readonly PushUpContext _context;

    public TipoDireccionRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}