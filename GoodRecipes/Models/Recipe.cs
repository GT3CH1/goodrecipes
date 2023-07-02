using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodRecipes.Models;

[Table("Recipes")]
public class Recipe
{
    public Recipe()
    {
        Name = null!;
        InstructionsPath = null!;
        Author = null!;
        IngredientSections = new();
        Hashtags = new();
    }

    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? ThumbnailPath { get; set; }
    [Required]
    public string InstructionsPath { get; set; }
    public string? StoryPath { get; set; }
    [Required]
    public DateTime TimeCreated { get; set; }
    [Required]
    public RecipeUser Author { get; set; }

    public List<IngredientSection> IngredientSections { get; set; }
    public List<Hashtag> Hashtags { get; set; }
}
