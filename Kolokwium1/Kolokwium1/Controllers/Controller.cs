using Kolokwium1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium1.Controllers;
[ApiController]
[Route("/api")]
public class Controller: ControllerBase
{
    private readonly IService _service;

    public Controller(IService service)
    {
        _service = service;
    }
}