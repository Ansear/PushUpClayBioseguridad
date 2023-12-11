using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;


namespace APP.Repository;
public class ContactoPerRepository : GenericRepository<Contactoper>, IContactoPer
{
    private readonly PushUpContext _context;

    public ContactoPerRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}