using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Student
{
    [Column("student_id")]
    [Key]
    public long student_id {get; set;}

    [Column("email_address")]
    public string email_address {get; set;}
}