namespace BLL.BEnt
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Dob { get; set; }
        public int DepartmentId { get; set; }

        public virtual DepartmentModel Department { get; set; }

    }
}
