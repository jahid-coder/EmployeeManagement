using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name="Mary", Department="HR",Email="m@gmail.com" },
                new Employee(){Id = 2, Name="John", Department="IT",Email="j@gmail.com"},
                new Employee(){Id = 3, Name="Sam", Department="IT",Email="s@gmail.com"},
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
