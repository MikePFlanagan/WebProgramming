using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "100",
                EmailAddress = "tom.smith@school.com"
            },
            new Student {
                Id = 2,
                StudentId = "200",
                EmailAddress = "mary.jones@school.com"
            }
        };

    
    }
}