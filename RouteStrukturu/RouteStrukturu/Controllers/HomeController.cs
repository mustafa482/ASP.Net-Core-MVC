using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouteStrukturu.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RouteStrukturu.Controllers
{
    [Route("ana")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("in")]
        public IActionResult Index(int id,string x,int y)
        {
            return View();
        }
        [Route("Priv/{id:int?}")]
        public IActionResult Privacy(int? id)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
