namespace School.DAL
{
    public partial class School
    {
        public class Student
        {
            public int StudentId { get; set; }
            public int StudentCode { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
        }
    }
}
