using Labb_2_API_Avancerad.NET.Models;
using Labb_2_API_Avancerad.NET.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb_2_API_Avancerad.NET.Controllers
{

    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAllEmployee()
        {
            var Employees = _employeeRepo.GetAllEmployees();
            return Ok(Employees);
        }

        [HttpGet]
        [Route("api/[controller]/{id:guid}")]
        [ActionName("GetSingleEmployee")]
        public IActionResult GetSingleEmployee([FromRoute] Guid id)
        {
            var employee = _employeeRepo.GetEmployeeById(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NotFound("Employee was not found.");
            }
        }

        [HttpPost]
        [Route("api/[controller]/Add")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            employee.EmployeeId = Guid.NewGuid();
            employee.FullName = employee.FirstName + ' ' + employee.LastName;
            _employeeRepo.AddEmployee(employee);
            return CreatedAtAction(nameof(GetSingleEmployee), new { id = employee.EmployeeId }, employee);
        }

        [HttpPut]
        [Route("api/[controller]/{id:guid}")]
        public ActionResult UpdateEmployee([FromRoute] Guid id, [FromBody] Employee employee)
        {
            var employeeToUpdate = _employeeRepo.GetEmployeeById(id);
            if (employeeToUpdate != null)
            {
                employeeToUpdate.FirstName = employee.FirstName;
                employeeToUpdate.LastName = employee.LastName;
                employeeToUpdate.Email = employee.Email;
                employeeToUpdate.Phone = employee.Phone;
                employeeToUpdate.City = employee.City;
                employeeToUpdate.Address = employee.Address;
                employeeToUpdate.ZipCode = employee.ZipCode;
                employeeToUpdate.DepartmentId = employee.DepartmentId;
                employeeToUpdate.GenderId = employee.GenderId;
                employeeToUpdate.Salary = employee.Salary;
                employeeToUpdate.FullName = employee.FirstName + ' ' + employee.LastName;

                _employeeRepo.Update(employeeToUpdate);
                return Ok(employeeToUpdate);
            }
            return NotFound("Employee was not found.");
        }

        [HttpDelete]
        [Route("api/[controller]/{id:guid}")]
        public ActionResult DeleteEmployee([FromRoute] Guid id)
        {
            var employeeToDelete = _employeeRepo.GetEmployeeById(id);
            if (employeeToDelete != null)
            {
                _employeeRepo.DeleteEmployee(employeeToDelete);
                return Ok(employeeToDelete);
            }
            else
            {
                return NotFound("Employee was not found.");
            }
        }


        public IActionResult Index()
        {
            return View();
        }

    }
}
