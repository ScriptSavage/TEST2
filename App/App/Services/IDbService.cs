﻿using App.Models;

namespace App.Services;

public interface IDbService
{
    Task<ICollection<Character>> GetEquipment(int id);

}