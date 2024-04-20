using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class StudentRepo
    {
        static SMSEntities db;
        static StudentRepo()
        {
            db = new SMSEntities();
        }
        public static List<Student> Get()
        {

            return db.Students.ToList();
        }

        public static Student Get(int id)
        {


            return db.Students.FirstOrDefault(x => x.Id == id);
        }
        public static void Edit(Student s)
        {
            var ds = db.Students.FirstOrDefault(x => x.Id == x.Id);
            db.Entry(ds).CurrentValues.SetValues(s);
            db.SaveChanges();

        }
        public static void Delete(int id)
        {
            var ds = db.Students.FirstOrDefault(x => x.Id == id);
            db.Students.Remove(ds);

        }


        public static void Add(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
        }


    }
}
