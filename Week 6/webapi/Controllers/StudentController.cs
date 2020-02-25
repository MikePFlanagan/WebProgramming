using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return Ok(getStudents());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Student student)
        {
            student.Id = getNextId();

            InMemory.students.Add(student);

            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            
            var student = InMemory.students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }

        private List<Student> getStudents()
        {
            return InMemory.students;
        }  

        private int getNextId()
        {
            return InMemory.students.Max(p => p.Id) + 1;
        }
    }
}