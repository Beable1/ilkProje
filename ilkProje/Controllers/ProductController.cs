using ilkProje.Models;
using ilkProje.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ilkProje.Controllers
{
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        readonly IConfiguration _configuration;
        public ProductController(IConfiguration configuration) { 
            _configuration = configuration;
        }

        public IActionResult GetProducts()
        {
            //var products = new List<Product>
            //{
            //    new Product { Id = 1,ProductName="product 1",Quanity=30},
            //    new Product { Id = 2, ProductName = "product 2", Quanity = 25 },
            //    new Product { Id = 3,ProductName="product 3",Quanity=20}
            //};
            

            Product product = new Product
            {
                Id = 1,
                ProductName = "Chair",
                Quanity=12
            };

            User user = new User
            {
                Id = 1,
                Name = "Ahmet",
                LastName = "Yılmaz"
            };

            //UserProduct userProduct = new UserProduct
            //{
            //    User=user,
            //    Product=product
            //};
            
            //return View(userProduct);

            //modelden akarım için gerekli
            //return View(products);


            //view bag dinamik olarak runtime'da değişkenin türünü belirler
            //ViewBag.products = products;
            //ViewData["products"] = products;


            //string data =JsonSerializer.Serialize(products);
            //TempData["products"]=data;

           //return RedirectToAction("Details","Product");

            return View();
        }

        //public IActionResult Details()
        //{
        //    var data = TempData["products"].ToString();
        //    List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);
            
        //    return View();
        //}

        //public ViewResult GetProducts() { 

        //    ViewResult result = View();
        //    return result;

        //}

        //public PartialViewResult GetProducts()
        //{

        //    PartialViewResult result = PartialView();
        //    return result;

        //}

        //public JsonResult GetJsonProducts()
        //{
        //    JsonResult result = Json(new Product
        //    {
        //        Id = 1,
        //        ProductName = "Test",
        //        Quanity = 20
        //    });
        //    return result;

        //}
          
        public IActionResult CreateProduct()
        {
            var isim=_configuration["Name"];
            Console.WriteLine(isim);
            return View();
        }

        [HttpPost]
        //public IActionResult CreateProduct(Product product) {

        //    return View(product);
        //}


        //[HttpPost] /*Form ile veri alma*/
        //public IActionResult VeriAl(IFormCollection datas)
        //{
        //    var productName = datas["ProductName"];
        //    var Quantity = datas["Quantity"];
        //    var Id = datas["Id"];
        //    Console.WriteLine(productName);
        //    return View();
        //}


        [HttpPost] 
        public IActionResult CreateProduct(Product model)
        {
             

            return View(model);
        }

        //QueryString Kullanarak veri alma
        //public IActionResult VeriAl(string a,string b)
        //{
        //    var queryString = Request.QueryString;
        //    var aa = Request.Query["a"].ToString();
        //    var bb = Request.Query["b"].ToString();
        //    Console.WriteLine($"{aa} and {bb}   ");
        //    return View();
        //}


        //public IActionResult VeriAl(string id,string a,string b) {

        //    var value = Request.RouteValues;
        //    Console.WriteLine(id);
        //    return View();
        //}


        public IActionResult VeriAl()
        {

            return View();
        }

    }
}
