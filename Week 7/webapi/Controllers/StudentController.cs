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
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            List<Student> list = _dbContext.Student.ToList();
            var result = list;
            return Ok(result);
        }

        //   [HttpGet("{studentId}")]
        // public ActionResult<Student> GetStudent(int studentId)
        // {
        //     var student = _dbContext.Student
        //         .SingleOrDefault(p => p.StudentId == studentId);

        //     if (student != null) {
        //         return student;
        //     } else {
        //         return NotFound();
        //     }
        // }

        //  [HttpPost]
        // public ActionResult<Student> AddStudent(Student student)
        // {
        //     _dbContext.Student.Add(student);
        //     _dbContext.SaveChanges();

        //     // return CreatedAtAction(nameof(GetStudent), new { id = student.student_Id }, student);

        //     return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        // }

        // [HttpDelete("{studentId}")]
        // public ActionResult DeleteStudent (int studentId)
        // {
        //     var student = new Student{tudentId = studentId};

        //     _dbContext.Student.Attach(student);
        //     _dbContext.Student.Remove(student);
        //     _dbContext.SaveChanges();

        //     return Ok();
        // }

    

        // [HttpPut("{studentId}")]
        // public ActionResult UpdateStudent(int studentId, Student studentUpdate)
        // {
        //     var student = _dbContext.Student
        //         .SingleOrDefault(p => p.StudentId == studentId);

        //     if (student != null)
        //     {
        //         student.StudentId = studentUpdate.StudentId;
        //         student.EmailAddress = studentUpdate.EmailAddress;
               

        //         _dbContext.Update(student);

        //         _dbContext.SaveChanges();
        //     }

        //     return NoContent();
        // }
    }
}