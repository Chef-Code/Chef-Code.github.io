using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeBuilder_Version_1.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }

        List<Ingredient> ingredients = new List<Ingredient>();

        public List<Ingredient> Ingredients 
        { 
            get { return ingredients; } 
        }

        public string Name { get; set; }

        
    }
}