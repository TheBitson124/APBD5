using project5.Database;

namespace project5.Models;

public class Visit
{
    public DateTime date { get; set; }
    public Animal animal{ get; set; }
    public String  description { get; set; }
    public int price{ get; set; }

    public Visit(DateTime date, int id, String description, int price)
    {
        this.date = date;
        this.animal = StaticAnimals.animals.FirstOrDefault(a=> a.Id == id,null);
        this.description = description;
        this.price = price;
    }
}