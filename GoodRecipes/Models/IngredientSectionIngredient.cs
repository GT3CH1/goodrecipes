namespace GoodRecipes.Models
{
    public class IngredientSectionIngredient
    {
        public IngredientSection Section { get; set; } = null!;
        public Ingredient Ingredient { get; set; } = null!;
        public int Order { get; set; }
    }
}
