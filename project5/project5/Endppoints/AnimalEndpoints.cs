namespace project5.Endppoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoint(this WebApplication app)
    {
        // GET
        app.MapGet("animals-minimalapi/{id}", (int id ) =>
        {
            return Results.Ok();
        });
        // POST
        app.MapPost("animals-minimalapi", () =>
        {
            return Results.Created();
        });
    }
}