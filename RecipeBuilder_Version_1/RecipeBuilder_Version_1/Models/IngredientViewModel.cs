using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeBuilder_Version_1.Models
{
    public class IngredientViewModel
    {
        public int IngredientID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Preparation { get; set; }

        public Recipe RecipeItem { get; set; }  //This is just a reference, it is not the whole container
    }
}