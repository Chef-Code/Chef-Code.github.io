﻿using System.Web;
using System.Web.Mvc;

namespace RecipeBuilder_Version_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
