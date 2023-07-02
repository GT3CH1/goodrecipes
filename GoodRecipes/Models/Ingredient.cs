using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GoodRecipes.Models;

[Table("Ingredients")]
[Index(nameof(Name), IsUnique = true)]
public class Ingredient
{
    public Ingredient()
    {
        Name = null!;
        UserWhoAdded = null!;
        TimeAdded = DateTime.UtcNow;
    }

    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public RecipeUser UserWhoAdded { get; set; }
    [Required]
    public DateTime TimeAdded { get; set; }
}
