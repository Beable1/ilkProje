using ilkProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace ilkProje.ViewComponents
{
    public class PersonellerViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Employee> datas = new List<Employee>
            {
                new Employee {Id = 1,Name = "Ayşegül",LastName="Yıldırım"},
                new Employee {Id = 2,Name = "Zeynep",LastName="Ameleoğlu"},
                new Employee {Id = 3,Name = "Mehmet",LastName="Yılmaz"},
                new Employee {Id = 4,Name = "Lütfü",LastName="Gündüz"},
                new Employee {Id = 5,Name = "Necip",LastName="Olgun"},
            };

            return View(datas);
        }
    }
}
