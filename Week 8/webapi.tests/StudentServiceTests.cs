using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock
    private const string OnSaleKey = "b";
    private const int LowInventoryCount = 3;

    [SetUp]
    public void Setup()
    {
        var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository, loggerFactory);
    }

    [Test]
    public void ShouldReturnSpecialStudentsOverQuota()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student{
                    StudentId = 800,
                    EmailAddress = "Test1@testaddress.com"
                },
               new Student{
                    StudentId = 860,
                    EmailAddress = "Test2@testaddress.com"
               }
            }
        );

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(sdto => sdto.Special), Is.EqualTo(true));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(sdto => sdto.Special).Should().BeTrue();
    }

 [Test]
    public void ShouldReturnNotSpecialStudentsUnderquota()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student{
                    StudentId = 200,
                    EmailAddress = "Test3@testaddress.com"
                },
                 new Student{
                    StudentId = 400,
                    EmailAddress = "Test4@testaddress.com"
                }
               
            
            }
        );

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(sdto => sdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(sdto => sdto.Special).Should().BeFalse();
    }

    
    [Test]
    public void ShouldReturnSpecialStudentswithinvalidEmailAddresses()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student{
                    StudentId = 200,
                    EmailAddress = "Test5testaddress.com"
                },
               new Student{
                    StudentId = 260,
                    EmailAddress = "Test6testaddress.com"
               }
            }
        );

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(sdto => sdto.Special), Is.EqualTo(true));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(sdto => sdto.Special).Should().BeTrue();
    }

 [Test]
    public void ShouldReturnNotSpecialStudentsWithValidEmailAddresses()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student{
                    StudentId = 220,
                    EmailAddress = "Test7@testaddress.com"
                },
                 new Student{
                    StudentId = 430,
                    EmailAddress = "Test8@testaddress.com"
                }
               
            
            }
        );

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(sdto => sdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(sdto => sdto.Special).Should().BeFalse();
    }

//     [Test]
//     public void ShouldReturnStudentsOnSale()
//     {
//         // Arrange
//         var expectedStudentName = OnSaleKey + "test";

//         A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
//             new List<Student> {
//                 new Student {
//                     Name = expectedStudentName,
//                     Price = 1.99m
//                 },
//                 new Student {
//                     Name = "student2",
//                     Price = 1.99m
//                 }
//             }
//         );

//         // Act
//         var studentViewModels = _studentService.GetAllStudents();

//         // Assert (FluentAssertions)
//         studentViewModels.Count(pdto => pdto.OnSale).Should().Be(1);
//         studentViewModels.Single(pdto => pdto.OnSale).Name.Should().Be(expectedStudentName);
//     }

//     [Test]
//     public void ShouldNotReturnStudentsWithLowInventory()
//     {
//         // Arrange
//         A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
//             new List<Student> {
//                 new Student {
//                     Name = "student1",
//                     Count = LowInventoryCount + 1
//                 },
//                 new Student {
//                     Name = "student2",
//                     Count = LowInventoryCount + 1
//                 }
//             }
//         );

//         // Act
//         var studentViewModels = _studentService.GetAllStudents();

//         // Assert (FluentAssertions)
//         studentViewModels.Any(pdto => pdto.LowInventory).Should().BeFalse();
//     }

//     [Test]
//     public void ShouldReturnStudentsWithLowInventory()
//     {
//         // Arrange
//         A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
//             new List<Student> {
//                 new Student {
//                     Name = "bike",
//                     Count = 4
//                 },
//                 new Student {
//                     Name = "student2",
//                     Count = LowInventoryCount - 1
//                 }
//             }
//         );

//         // Act
//         var studentViewModels = _studentService.GetAllStudents();

//         // Assert (FluentAssertions)
//         studentViewModels.Single(pdto => pdto.LowInventory).Name.Should().Be("student2");
//     }
// }
}