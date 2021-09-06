using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.EmployeeManagement.UI.Model;

namespace WPF.EmployeeManagement.UI.Data
{
    public class EmployeeDataService : IEmployeeDataService
    {
        public IEnumerable<Employee> GetEmployees()
        {
            yield return new Employee { Id = 1, Firstname = "Rafael", Lastname = "Milanes", Email = "johnny@gmail.com", Department = Department.IT };
            yield return new Employee { Id = 2, Firstname = "Johnny", Lastname = "Cage", Email = "Juan@gmail.com", Department = Department.IT };
            yield return new Employee { Id = 3, Firstname = "Anna", Lastname = "Lindgren", Email = "Anna@gmail.com", Department = Department.Agriculture };
            yield return new Employee { Id = 4, Firstname = "Juanete", Lastname = "Pérez", Email = "John@gmail.com", Department = Department.Education };
            yield return new Employee { Id = 5, Firstname = "New", Lastname = "SuperNew", Email = "new@gmail.com", Department = Department.Education };
        }
    }
}
