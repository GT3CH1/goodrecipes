namespace GoodRecipes.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public RecipeUser UserWhoAdded { get; set; } = null!;
    public DateTime TimeAdded { get; set; }
}
