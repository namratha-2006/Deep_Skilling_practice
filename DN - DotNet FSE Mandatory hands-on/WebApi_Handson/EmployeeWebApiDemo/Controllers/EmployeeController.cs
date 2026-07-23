using EmployeeWebApiDemo.Filters;
using Microsoft.AspNetCore.Mvc;
using EmployeeWebApiDemo.Models;

namespace EmployeeWebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Rahul",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1998,5,10),
                    Department = new Department
                    {
                        Id = 101,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill{ Id=1, Name="C#" },
                        new Skill{ Id=2, Name="SQL" }
                    }
                },

                new Employee
                {
                    Id = 2,
                    Name = "Priya",
                    Salary = 45000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1999,8,20),
                    Department = new Department
                    {
                        Id = 102,
                        Name = "HR"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill{ Id=3, Name="Java" }
                    }
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            throw new Exception("Custom Exception Generated");
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return Ok(employees.FirstOrDefault(e => e.Id == id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok("Employee Added");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            return Ok("Employee Updated");
        }
    }
}