namespace School
{
    public class Student:Person
    {
        public string Enrollment { get; set; }

        public List<double> Grades { get; set; } = new List<double>();
    }
}