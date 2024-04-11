namespace project5.Models;

public class Animal
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Category { get; set; }
    public int Mass { get; set; }
    public string FurColor { get; set; }

    public Animal(int id, string firstName, string category, int mass, string furColor)
    {
        Id = id;
        FirstName = firstName;
        Category = category;
        Mass = mass;
        FurColor = furColor;
    }
}