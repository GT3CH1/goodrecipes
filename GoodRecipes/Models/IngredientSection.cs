namespace GoodRecipes.Models;

public class IngredientSection
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public Recipe Recipe { get; set; } = null!;
    public int Order { get; set; }

    public List<IngredientSectionIngredient> Ingredients { get; set; } = null!;
}
