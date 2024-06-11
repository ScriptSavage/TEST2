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
}