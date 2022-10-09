using Labb_2_API_Avancerad.NET.Models;

namespace Labb_2_API_Avancerad.NET.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(Guid id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                return null;
            }
            return employee;
        }

        public Employee Update(Employee employeeToUpdate)
        {
            var employee = _context.Employees.Find(employeeToUpdate.EmployeeId);
            if (employee != null)
            {
                employee.FirstName = employeeToUpdate.FirstName;
                employee.LastName = employeeToUpdate.LastName;
                employee.Email = employeeToUpdate.Email;
                employee.Address = employeeToUpdate.Address;
                employee.City = employeeToUpdate.City;
                employee.ZipCode = employeeToUpdate.ZipCode;
                employee.Phone = employeeToUpdate.Phone; 
                employee.Salary = employeeToUpdate.Salary;
                employee.GenderId = employeeToUpdate.GenderId;
                employee.DepartmentId = employeeToUpdate.DepartmentId;
                _context.Employees.Update(employee);
                _context.SaveChanges();
            }
            return employeeToUpdate;
        }
    }
}
