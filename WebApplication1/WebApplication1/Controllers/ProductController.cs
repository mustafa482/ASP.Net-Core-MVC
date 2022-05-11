using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.Models.ModelMetaDataTypes;

namespace WebApplication1.Controllers
{

    public class MyClass {
        public int id { get; set; }
        public string A { get; set; }
        public string B { get; set; }

    }
   //public class AjaxData
   // {
   //     public string A { get; set; }
   //     public string B { get; set; }
   // }
    public class ProductController : Controller
    {
        
       
        public IActionResult GetProducts()
        {
            


           
            return View();

        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
                //ViewBag.XetaMesaj = ModelState.Values.FirstOrDefault(x=>x.ValidationState==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;
            }

            return View();
        }
















        //public IActionResult CreateProduct()
        //{
        //    var tuple = (new Product(), new User());

        //    return View(tuple);
        //}
        //[HttpPost]
        //public IActionResult CreateProduct([Bind(Prefix ="Item1")] Product product,[Bind(Prefix ="Item2")] User user)
        //{

        //    return View();
        //}




        //[HttpPost]
        //public IActionResult AjaxVeriAl(AjaxData ajaxdata)
        //{


        //    return View();
        //}

        //public IActionResult CreateProduct()
        //{
        //    var product = new Product()
        //    {
        //        ProductName = "Xiyar",
        //        Quantity = 31
        //    };

        //    return View(product);
        //}

        //[HttpPost]
        ////public IActionResult CreateProduct(string txtProductName,string txtQuantity)
        //public IActionResult CreateProduct(Product product)
        //{
        //    return View();
        //}




















        //public IActionResult VeriAl(MyClass myClass)
        //{

        //    var headers = Request.Headers.ToList();

        //    //var values = Request.RouteValues;


        //    return View();
        //}







        //public IActionResult DataAl(/*string a,string b*/)
        //{
        //    var querystring = Request.QueryString;//Request edilen endpointe query string parametri elave olunub olunmamagini yoxlayir

        //    var a = Request.Query["a"].ToString();

        //    return View();
        //}







        //[HttpPost]
        //public IActionResult DataAl(IFormCollection datas)
        //{
        //    var value1 = datas["txtData1"];
        //    var value2 = datas["txtData2"];
        //    var value3 = datas["txtData3"];


        //    return View();
        //}
    }
}
