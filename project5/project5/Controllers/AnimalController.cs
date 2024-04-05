using Microsoft.AspNetCore.Mvc;
using project5.Database;

namespace project5.Controllers;
[ApiController]
[Route("[controller]")]
public class AnimalController:ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var a = StaticData.animals;
        var b = new MockDb();
        return Ok(b);
    }
}