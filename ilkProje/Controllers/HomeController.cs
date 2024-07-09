using ilkProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace ilkProje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product();
            product.Id = 2;

            return View();


        }

       

    }
}
