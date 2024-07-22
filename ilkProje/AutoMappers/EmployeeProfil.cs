using AutoMapper;
using ilkProje.Models;
using ilkProje.Models.ViewModels;

namespace ilkProje.AutoMappers
{
    public class EmployeeProfil:Profile
    {
        public EmployeeProfil() {
            CreateMap<EmployeeCreateVM, Employee>();
			CreateMap<Employee, EmployeeCreateVM>();
		}
    }
}
