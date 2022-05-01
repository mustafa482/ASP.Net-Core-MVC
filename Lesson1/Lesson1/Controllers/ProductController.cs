using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var products = new List<Product>
            {
                new Product{ Id = 1, ProductName="A product",Qauntity = 10},
                new Product{ Id = 2, ProductName="B product",Qauntity = 15},
                new Product{ Id = 3, ProductName="C product",Qauntity = 20}


            };

            #region Model Bazli Veri gonderimi

            //return View(products);

            #endregion

            #region Data dasima controllari


            #endregion

            #region ViewBag
            //ViewBag.products = products;
            #endregion
            #region ViewData
            //ViewData["products"] = products;

            #endregion
            #region TempData
            //TempData["produts"] = products;
            #endregion



            string data = JsonSerializer.Serialize(products);
            TempData["products"] = data;



            return RedirectToAction("Index2");
        }
        public IActionResult Index2()
        {

            var d1 = TempData["proucts"].ToString();
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(d1);
           
            return View();
        }
    }
}
