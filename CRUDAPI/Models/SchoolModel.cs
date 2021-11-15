namespace CRUDAPI.Models
{
    public class SchoolModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } 

    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Section { get; set; }
    }
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Section { get; set; }
    }
}
