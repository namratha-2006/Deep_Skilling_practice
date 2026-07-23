using Microsoft.AspNetCore.Mvc;
using EmployeeCrudApiDemo.Models;

namespace EmployeeCrudApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee{ Id=1, Name="Rahul", Salary=50000, Permanent=true},
            new Employee{ Id=2, Name="Priya", Salary=45000, Permanent=false},
            new Employee{ Id=3, Name="Kiran", Salary=60000, Permanent=true}
        };

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return BadRequest("Invalid employee id");

            return Ok(emp);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return BadRequest("Invalid employee id");

            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Permanent = employee.Permanent;

            return Ok(emp);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return BadRequest("Invalid employee id");

            employees.Remove(emp);

            return Ok("Employee Deleted");
        }
    }
}