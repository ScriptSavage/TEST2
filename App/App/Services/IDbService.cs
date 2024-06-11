using App.Models;

namespace App.Services;

public interface IDbService
{
    Task<ICollection<Character>> GetEquipment(int id);

    Task<bool> DoesAllItemsExists(Item item);


    Task<bool> DoesCharacterExists(int id);


    Task<bool> DoesCharacterMaxWeightIsValid(int id);



}