using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)         
        {
         
        }
        
        public DbSet<Student> Student { get; set; }
      
    }
}