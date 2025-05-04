namespace School
{
    public class AcademicTeacher : Teacher
    {
        public AcademicTeacher(string name, int age, string registry, double basesalary, int overtime) : base(name, age, registry, basesalary, overtime) { }

         public override bool CanRetire()
        {
            return Age > 65;
        }

        public override double CalculateRetirement()
        {
            return base.CalculateRetirement() + 1.000;
        }


    }
}