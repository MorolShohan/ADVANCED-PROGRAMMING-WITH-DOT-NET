using DAL.EF.Entities;
using System.Collections.Generic;

namespace DAL.Repos
{
    public class StudentRepo
    {
        public void Create(Student s) { } //parameter will rcv a student obj
        public Student Get(int id) { return null; }
        public List<Student> Get() { return null; }
        public void Update(Student s) { }
        public void Delete(int id) { }

    }
}
