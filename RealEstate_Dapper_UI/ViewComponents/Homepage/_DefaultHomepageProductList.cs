﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.Homepage
{
    public class _DefaultHomepageProductList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
