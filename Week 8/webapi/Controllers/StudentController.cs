using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        //private readonly ILogger _logger;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
           // _logger = loggerFactory.CreateLogger("Controllers.StudentController");
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            //_logger.LogDebug("Getting all students");

            

            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{studentId}")]
        public ActionResult<Student> GetStudent(int studentId)
        {
            var student = _studentService.GetStudentById(studentId);

            if (student != null) {
                return Ok(student);
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            _studentService.AddStudent(student);

            return CreatedAtAction(nameof(GetStudent), new { id = student.StudentId }, student);

            //return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpPut("{studentId}")]
        public ActionResult UpdateStudent(int studentId, Student studentUpdate)
        {
            studentUpdate.StudentId = studentId;
            _studentService.UpdateStudent(studentUpdate);

            return NoContent();
        }

       [HttpDelete("{studentId}")]
        public ActionResult DeleteStudent(int studentId)
        {
            _studentService.DeleteStudent(studentId);

            return Ok();
        }
    }
}

