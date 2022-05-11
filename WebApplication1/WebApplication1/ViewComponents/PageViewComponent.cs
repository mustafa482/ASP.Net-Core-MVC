using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewComponents
{
    public class PageViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
