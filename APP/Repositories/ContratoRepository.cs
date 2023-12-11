using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class ContratoRepository : GenericRepository<Contrato>, IContrato
{
    private readonly PushUpContext _context;

    public ContratoRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}