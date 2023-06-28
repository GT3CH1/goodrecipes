namespace GoodRecipes.Models;

public class Hashtag
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime TimeCreated { get; set; }

    public List<Recipe> Recipes { get; set; } = null!;
}
