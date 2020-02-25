using System.Collections.Generic;
using webapi;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "1",
                EmailAddress = "M.Jackson@ABCSchool.com"
            },
            new Student {
                Id = 2,
                StudentId = "2",
                EmailAddress = "J.Jackson@ABCSchool.com"
            },
            new Student {
                Id = 3,
                StudentId = "3",
                EmailAddress = "R.Jackson@ABCSchool.com"
            },
             new Student {
                Id = 4,
                StudentId = "4",
                EmailAddress = "T.Jackson@ABCSchool.com"
            },
            new Student {
                Id = 5,
                StudentId = "5",
                EmailAddress = "J.Jackson@ABCSchool.com"
            }
        };   
         public static List<Instructor> instructors = new List<Instructor> {
            new Instructor {
                Id = 1,
                FirstName = "James",
                MiddleInitial = "T",
                LastName = "Kirk"
            },
            new Instructor {
                Id = 2,
                FirstName = "Schn",
                MiddleInitial = "T",
                LastName = "Spock"
            },
            new Instructor {
                Id = 3,
                FirstName = "Benjamin",
                MiddleInitial = "L",
                LastName = "Sisk0"
            },            
            new Instructor {
                Id = 4,
                FirstName = "Jean",
                MiddleInitial = "L",
                LastName = "Picard"
            },
            new Instructor {
                Id = 5,
                FirstName = "Kathryn",
                MiddleInitial = "H",
                LastName = "Janeway"
            },
            new Instructor {
                Id = 6,
                FirstName = "Jonathan",
                MiddleInitial = "P",
                LastName = "Archer"
            }
           
        };                       
    }
}