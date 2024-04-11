using project5.Models;

namespace project5.Database;

public class StaticAnimals
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1,"Nasus","pies",10,"czarny"),
        new Animal(2,"Kicia","kot",5,"brązowy"),
        new Animal(3,"Bunny","królik",2,"biały"),
        new Animal(4,"buns","królik",3,"szary"),
    };
}