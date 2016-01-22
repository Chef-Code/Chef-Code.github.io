using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeBuilder_Version_1.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        List<Recipe> recipes = new List<Recipe>();

        public List<Recipe> Recipes { get { return recipes; } }
    }
}