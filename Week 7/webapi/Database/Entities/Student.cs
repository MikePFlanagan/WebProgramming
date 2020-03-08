using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Student
{
    [Column("student_id")]
    [Key]
    public long StudentId {get; set;}

    [Column("email_address")]
    public string EmailAddress {get; set;}
}