using App.Data;
using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Services;

public class DbService : IDbService
{

    private readonly KolosContext _context;


    public DbService(KolosContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Character>> GetEquipment(int id)
    {
        var x = await _context.Characters
            .Where(e=>e.Id == id)
            .Include(e => e.Backpacks)
            .ThenInclude(e => e.Item)
            .ToListAsync();

        return x;
    }
}