using DAL.EF.Entities;
using System.Collections.Generic;

namespace DAL.Repos
{
    public class CourseRepo
    {
        public void Create(Course s) { } //parameter will rcv a course obj
        public Course Get(int id) { return null; }
        public List<Course> Get() { return null; }
        public void Update(Course s) { }
        public void Delete(int id) { }
    }
}
