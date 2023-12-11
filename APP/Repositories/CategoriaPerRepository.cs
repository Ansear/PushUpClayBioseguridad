using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;
using Persistence.Data;

namespace APP.Repository;
public class CategoriaPerRepository : GenericRepository<Categoriaper>, ICategoriaPer
{
    private readonly PushUpContext _context;

    public CategoriaPerRepository(PushUpContext context) : base(context)
    {
        _context = context;
    }
}