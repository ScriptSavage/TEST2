using App.Data;

namespace App.Services;

public class DbService : IDbService
{

    private readonly KolosContext _context;


    public DbService(KolosContext context)
    {
        _context = context;
    }
}