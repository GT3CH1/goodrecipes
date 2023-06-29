using System.ComponentModel.DataAnnotations;

namespace GoodRecipes.Models
{
    public class IngredientSectionIngredient
    {
        public IngredientSection Section { get; set; } = null!;
        public Ingredient Ingredient { get; set; } = null!;
        [Key]
        public int Id { get; set; }
        public int Order { get; set; }
    }
}
