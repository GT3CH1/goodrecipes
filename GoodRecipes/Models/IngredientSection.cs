using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GoodRecipes.Models;

[Table("IngredientSections")]
[Index(nameof(RecipeId), nameof(Order), IsUnique = true)]
public class IngredientSection
{
    public IngredientSection()
    {
        Recipe = null!;
        Order = 1;
        Ingredients = new();
    }

    public Guid Id { get; set; }
    public string? Title { get; set; }
    [Required]
    public Guid RecipeId { get; set; }
    [Required]
    public int Order { get; set; }

    [ForeignKey("RecipeId")]
    public Recipe Recipe { get; set; }
    public List<IngredientSectionIngredient> Ingredients { get; set; }
}
