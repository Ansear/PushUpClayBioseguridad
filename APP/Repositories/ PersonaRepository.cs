using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.Repository;
public class PersonaRepository : GenericRepository<Persona>, IPersona
{
    private readonly PushUpContext _context;

    public PersonaRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}