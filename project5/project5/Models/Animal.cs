namespace project5.Models;

public class Animal
{
    public int Id { get; set; }
    public String FirstName { get; set; }
    public String Category { get; set; }
    public int Mass { get; set; }
    public string FurColor { get; set; }

    public Animal(int id, String firstName, String category, int mass, String furColor)
    {
        Id = id;
        FirstName = firstName;
        Category = category;
        Mass = mass;
        FurColor = furColor;
    }
}