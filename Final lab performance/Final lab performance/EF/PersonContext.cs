using Final_lab_performance.EF.Tbls;
using System.Data.Entity;

namespace Final_lab_performance.EF
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}