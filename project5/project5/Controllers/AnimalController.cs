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
    [Route("/api/animals")]
    public IActionResult GetAnimals()
    {
        var b = StaticAnimals.animals;
        return Ok(b);
    }

    [HttpGet]
    [Route("/api/animals/{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var b = StaticAnimals.animals;
        var animal = b.FirstOrDefault(a => a.Id == id);
        return Ok(animal);
    }

    [HttpPost]
    [Route("/api/animals/{id:int}/{FirstName}/{Category}/{mass:int}/{FurColor}")]
    public IActionResult PostAnimal(int id, string FirstName, string Category, int mass, string FurColor)
    {
        var animal = new Animal(id, FirstName, Category, mass, FurColor);
        StaticAnimals.animals.Add(animal);
        return Ok();
    }
    [HttpPut]
    [Route("/api/animals/{id:int}/{FirstName}/{Category}/{mass:int}/{FurColor}")]
    public IActionResult PutAnimal(int id, string FirstName, string Category, int mass, string FurColor)
    {
        var b = StaticAnimals.animals;
        var animal = b.FirstOrDefault(a => a.Id == id);
        animal = new Animal(id, FirstName, Category, mass, FurColor);
        return Ok();
    }

    [HttpDelete]
    [Route("/api/animals/{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var b = StaticAnimals.animals;
        b.Remove(b.FirstOrDefault(a => a.Id == id));
        return Ok();
    }
    
} 