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

    public async Task<bool> DoesAllItemsExists(Item item)
    {

        var x = await _context.Items.AnyAsync(e => e.Id == item.Id);

        return x;
    }

    public async Task<bool> DoesCharacterExists(int id)
    {
        var x = await _context.Characters.AnyAsync(e => e.Id == id);


        return x;
    }

    public async Task<bool> DoesCharacterMaxWeightIsValid(int id)
    {

       

        throw new NotImplementedException();
    }
}