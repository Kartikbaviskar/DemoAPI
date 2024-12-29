using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {List<Student> students= new List<Student>();
        
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

       
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id ==id);
        }

        
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            students.Add(value);
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
          int i= students.FindIndex(s => s.Id == id)
                if(i>=0)
                students[i] = value;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
