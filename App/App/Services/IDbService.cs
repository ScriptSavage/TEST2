using App.Models;

namespace App.Services;

public interface IDbService
{
    Task<ICollection<Character>> GetEquipment(int id);

    Task<bool> DoesAllItemsExists(int itemId);


    Task<bool> DoesCharacterExists(int id);


    Task<bool> DoesCharacterMaxWeightIsValid(int id,int backPackAmout);


    Task AddNewItemToBack(int itemId , int Amout , int CharacterId);



}