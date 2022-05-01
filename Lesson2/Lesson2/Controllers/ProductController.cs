using Lesson2.Models;
using Lesson2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lesson2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{Id = 1,ProductName ="A product",Quantity = 10},
                new Product{Id = 2,ProductName ="B product",Quantity = 15},
                new Product{Id = 3,ProductName ="C product",Quantity = 20}

            };

            return View();
        }
        
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult GetProducts()
        {

            Product product = new Product
            {
                Id = 1,
                ProductName = "A product",
                Quantity = 10
            };

            User user = new User
            {
                Id = 1,
                Name = "Mustafa",
                LastName = "Mustafayev"
            };

            UserProduct userProduct = new UserProduct
            {
                User = user,
                Product = product
            };
            return View(userProduct);

        }
    }
}
