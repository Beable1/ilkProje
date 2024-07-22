using AutoMapper;
using ilkProje.Models;
using ilkProje.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ilkProje.Controllers
{
	[Route("[controller]/[action]")]
	public class EmployeeController : Controller
    {
        public IMapper Mapper { get;}

        public EmployeeController(IMapper mapper)
        {
            Mapper = mapper;   
        }

        [HttpPost]
        public IActionResult Index(EmployeeCreateVM employeeCreateVM)
        {
            Employee e = Mapper.Map<Employee>(employeeCreateVM);
            EmployeeCreateVM evm = Mapper.Map<EmployeeCreateVM>(e);
            Console.WriteLine(e.Name);
			Console.WriteLine(evm.Name);
			return View();
        }

        public IActionResult Index() {
            return View();
        }


    }
}
