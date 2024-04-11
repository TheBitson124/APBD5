using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using project5.Database;
using project5.Models;

namespace project5.Controllers;
[ApiController]
[Route("[controller]")]
public class AnimalController:ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var b = StaticData.animals;
        return Ok(b);
    }

    [HttpGet]
    public IActionResult GetAnimal(int id)
    {
        var b = StaticData.animals;
        var animal = b.FirstOrDefault(a => a.Id == id);
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult PostAnimal(int id, string FirstName, string Category, int mass, string FurColor)
    {
        var animal = new Animal(id, FirstName, Category, mass, FurColor);
        StaticData.animals.Add(animal);
        return Ok();
    }
    [HttpPut]
    public IActionResult PutAnimal(int id, string FirstName, string Category, int mass, string FurColor)
    {
        var b = StaticData.animals;
        var animal = b.FirstOrDefault(a => a.Id == id);
        animal = new Animal(id, FirstName, Category, mass, FurColor);
        return Ok();
    }

    [HttpDelete]
    public IActionResult PutAnimal(int id)
    {
        var b = StaticData.animals;
        b.Remove(b.FirstOrDefault(a => a.Id == id));
        return Ok();
    }
    
} 