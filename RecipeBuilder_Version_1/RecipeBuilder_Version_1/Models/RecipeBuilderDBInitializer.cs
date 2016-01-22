using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RecipeBuilder_Version_1.Models
{
    public class RecipeBuilderDBInitializer : DropCreateDatabaseAlways<RecipeBuilder_Version_1Context>
    {
        protected override void Seed(RecipeBuilder_Version_1Context context)
        {
            
            Recipe recipe1 = new Recipe { Name = "Hollandaise" };

            Ingredient egg = new Ingredient { Name = "eggs", Amount = 1.0m, Preparation = "Boil" };
            recipe1.Ingredients.Add(egg);
            context.Recipes.Add(recipe1);

            base.Seed(context);
        }
    }
}