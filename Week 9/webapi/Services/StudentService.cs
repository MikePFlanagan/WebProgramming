using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRespository;
   // private readonly ILogger _logger;

    public StudentService(IStudentRepository studentRepository, ILoggerFactory loggerFactory)
    {
        _studentRespository = studentRepository;
        //_logger = loggerFactory.CreateLogger("Controllers.StudentService");
    }

    public List<StudentViewModel> GetAllStudents()
    {
        var studentViewModels = new List<StudentViewModel>();

        foreach(var student in _studentRespository.GetAllStudents())
        {
            studentViewModels.Add(new StudentViewModel {
                StudentId = student.StudentId,
                EmailAddress = student.EmailAddress,                
                OverQuota = BusinessRules.isOverQuota(student),
                InvalidEmail = BusinessRules.isInvalidEmail(student),
                Special = BusinessRules.isSpecial(student)
            });
            if (BusinessRules.isOverQuota(student))
            {
                //_logger.LogInformation("Found Student over maximum allowed students: " + student.StudentId);
            }
        }

        return studentViewModels;
    }

    public Student GetStudentById(long studentId)
    {
        return _studentRespository.GetStudentById(studentId);
    }

    public void AddStudent(Student student)
    {
        _studentRespository.AddStudent(student);
    }

    public void UpdateStudent(Student student)
    {
        _studentRespository.UpdateStudent(student);
    }

    public void DeleteStudent(long studentId)
    {
        _studentRespository.DeleteStudent(studentId);
    }
}
