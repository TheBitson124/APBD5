using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using project5.Database;
using project5.Models;

namespace project5.Controllers;
[ApiController]
//[Route("[controller]")]
public class VisitController:ControllerBase
{
    [HttpGet]
    [Route("/api/visit/{id:int}")]
    public IActionResult GetAnimalsVisits(int animal_id)
    {
        var animal_visits = new List<Visit>();
        foreach (var visit in StaticVisits.Visits)
        {
            if (visit.animal.Id == animal_id)
            {
                animal_visits.Add(visit);
            }
        }
        return Ok(animal_visits);
    }
    [HttpPost]
    [Route("/api/animals/{date:DateTime}/{animal_id:int}/{description}/{price:int}")]
    public IActionResult PostAnimalVisit(DateTime date,int animal_id,string description,int price)
    {
        StaticVisits.Visits.Add(new Visit(date,animal_id,description,price));
        return Ok();
    }



}
