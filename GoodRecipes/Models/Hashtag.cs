using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GoodRecipes.Models;

[Table("Hashtags")]
[Index(nameof(Name), IsUnique = true)]
public class Hashtag
{
    public Hashtag()
    {
        Name = null!;
        TimeCreated = DateTime.UtcNow;
        Recipes = new();
    }

    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public DateTime TimeCreated { get; set; }

    public List<Recipe> Recipes { get; set; }
}
