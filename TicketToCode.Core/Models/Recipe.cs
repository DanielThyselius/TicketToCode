namespace TicketToCode.Core.Models;

public class Recipe
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public required string Instructions { get; set; }
    public required Category Category { get; set; }

    public Recipe()
    {
        Ingredients = new List<Ingredient>();
    }
}