namespace GoodRecipes.Models;

public class Recipe
{
    public string Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string ThumbnailPath { get; set; } = null!;
    public string InstructionsPath { get; set; } = null!;
    public string? StoryPath { get; set; }
    public DateTime TimeCreated { get; set; }
    public RecipeUser Author { get; set; } = null!;

    public List<IngredientSection> IngredientSections { get; set; } = null!;
    public List<Hashtag> Hashtags { get; set; } = null!;
}
