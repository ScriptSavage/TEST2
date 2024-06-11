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

    public async Task<bool> DoesAllItemsExists(int itemId)
    {

        var x = await _context.Items.AnyAsync(e => e.Id == itemId);

        return x;
    }

    public async Task<bool> DoesCharacterExists(int id)
    {
        var x = await _context.Characters.AnyAsync(e => e.Id == id);


        return x;
    }

    public async Task<bool> DoesCharacterMaxWeightIsValid(int id , int backPackAmout)
    {

        var x = await _context.Backpacks.Where(e => e.CharacterId == id).
            AnyAsync(e=>e.Amount < backPackAmout);

        return x;


    }

    public Task AddNewItemToBack(int itemId, int Amout, int CharacterId)
    {
        
        
        throw new NotImplementedException();
    }
}