namespace School
{
    public class Student : Person
    {
        public string Enrollment { get; set; }

        public List<double> Grades { get; set; } = new List<double>();

        public Student(string name, int age, string enrollment) : base(name, age)
        {
            this.Enrollment = enrollment;

        }

        public void AddGrades(double grade)
        {
            Grades.Add(grade);
        }
        public void AddGrades(double grade1, double grade2)
        {
            Grades.Add(grade1);
            Grades.Add(grade2);
        }

        public double CalcAverage()
        {
            if (Grades.Count == 0) return 0;
            double sum = 0;
            foreach (var grade in Grades)
                sum += grade;
            return sum / Grades.Count;
        }

        public string Condition()
        {
            return CalcAverage() >= 7.0 ? "Approved" : "Not Approved";
        }

        public void Info()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine("Student Grades: " + string.Join(", ", Grades));
            Console.WriteLine($"Student Average: {CalcAverage():F2}");
            Console.WriteLine($"Student Condition: {Condition()}");
        }

    }



}