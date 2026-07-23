using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpController : ControllerBase
    {
        // GET: api/Values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET: api/Values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Value: {id}");
        }

        // POST: api/Values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok("Value Added");
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok("Value Updated");
        }

        // DELETE: api/Values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Value Deleted");
        }
    }
}