namespace School
{
    public class Teacher : Person
    {
        public string Registry { get; set; }
        public double BaseSalary { get; set; }
        public int Overtime { get; set; }

        public Teacher(string name, int age, string registry, double basesalary, int overtime) : base(name, age)
        {
            this.Registry = registry;
            this.BaseSalary = basesalary;
            this.Overtime = overtime;
        }

        public virtual double CalculateFinalSalary()
        {
            return BaseSalary + (Overtime * 40);
        }

        public virtual bool CanRetire()
        {
            return Age > 60;
        }

        public virtual double CalculateRetirement()
        {
            return CalculateFinalSalary() * 0.75;
        }
    }
}