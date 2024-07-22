using ilkProje.Models;
using ilkProje.Services.İnterfaces;
using Microsoft.AspNetCore.Mvc;

namespace ilkProje.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {

        readonly ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }
        public IActionResult Index()
        {

            _log.Log();
            return View();


        }

       

    }
}
