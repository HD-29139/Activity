namespace School
{
    public class BasicTeachingTeacher : Teacher
    {
        public BasicTeachingTeacher(string name, int age, string registry, double basesalary, int overtime) : base(name, age, registry, basesalary, overtime) { }

        public override bool CanRetire()
        {
            return Age > 55;
        }

        public override double CalculateRetirement()
        {
            return CalculateFinalSalary() * 0.90;
        }
        
    }
}