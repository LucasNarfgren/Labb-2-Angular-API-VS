using Labb_2_API_Avancerad.NET.Models;

namespace Labb_2_API_Avancerad.NET.Services
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(Guid id);
        List<Employee> GetAllEmployees();
        Employee Update(Employee employee);
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
