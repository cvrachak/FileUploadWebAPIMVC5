﻿using System.Web;
using System.Web.Mvc;

namespace FileUploadWebAPIMVC5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
