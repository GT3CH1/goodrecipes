using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GoodRecipes.Models;

public enum Unit
{
    mg,
    g,
    kg,
    mL,
    L,
    c,
    tbsp,
    tsp,
    pt,
    qt,
    gal,
    oz
}

[Table("IngredientSectionIngredients")]
[Index(nameof(SectionId), nameof(IngredientId), IsUnique = true)]
[Index(nameof(SectionId), nameof(Order), IsUnique = true)]
public class IngredientSectionIngredient
{
    public IngredientSectionIngredient()
    {
        Section = null!;
        Ingredient = null!;
    }

    public Guid Id { get; set; }
    [Required]
    public Guid SectionId { get; set; }
    [Required]
    public Guid IngredientId { get; set; }
    [Required]
    public int Order { get; set; }

    [ForeignKey("SectionId")]
    public IngredientSection Section { get; set; }
    [ForeignKey("IngredientId")]
    public Ingredient Ingredient { get; set; }
}
