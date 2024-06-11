using App.DTOs;
using App.Models;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class Controller : ControllerBase
{
    private readonly IDbService _service;


    public Controller(IDbService service)
    {
        _service = service;
    }


    [HttpGet]

    public async Task<IActionResult> GetCharacterInfo(int id)
    {

        var checkValid = await _service.DoesCharacterExists(id);

        if (!checkValid)
        {
            return StatusCode(StatusCodes.Status404NotFound);
        }

        var x = await _service.GetEquipment(id);

        return Ok(x.Select(e => new ReturnItemsDTO()
        {
                FirstName = e.FirstName,
                LastName = e.LastName,
                CurrentWeight = e.CurrentWeight,
                MaxWeight = e.MaxWeight,
                EqDtos = e.Backpacks.Select(e=> new EqDTO()
                {
                    Name = e.Item.Name,
                    Weight = e.Item.Weight,
                    Amount = e.Amount
                }).ToList()
        }));

    }


    [HttpPost]
    public async Task<IActionResult> AddNewItem(int charactedID , int itemId)
    {
        var checkValid = await _service.DoesCharacterExists(charactedID);

        var doesItemExists = await _service.DoesAllItemsExists(itemId);

        var checkWieghtClass = await _service.DoesCharacterMaxWeightIsValid(charactedID, itemId);
        if (!checkValid || !doesItemExists)
        {
            return StatusCode(StatusCodes.Status404NotFound);
        }


        var newItem = new Item()
        {

        };

        
        return Created();
    }

}