// Copyright (c) 2022. Gavin Pease and contributors.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do so, subject to the
// following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial
// portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT
// OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GoodRecipes.Data.Models;

public class RecipeUser : IdentityUser
{
    [Required]
    [Display(Name = "Username")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "Suspended")]
    public bool Suspended { get; set; } = false;

    [Display(Name = "End of Suspension")] public DateTime? EndOfSuspension { get; set; } = null!;

    public List<Ingredient>? FoodPreferences { get; set; } = null!;

    public List<Recipe>? Recipes { get; set; } = null!;

    // public List<int>? FavoriteRecipes { get; set; } = null;

    // public List<int>? Reviews { get; set; } = null;

    // public List<string>? Following { get; set; } = null!;
}