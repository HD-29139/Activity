using School;

Console.WriteLine("\t");
Console.WriteLine("Students");
Console.WriteLine("-------------------");
Student student1 = new Student("Samuel Sandoval", 15, "xedW6FC7jMxrs");
student1.AddGrades(7.8);
student1.Info();
Console.WriteLine("-------------------");
Student student2 = new Student("Craig McDaniel", 17, "88sJyKqCSv7cS");
student2.AddGrades(2.3, 3.7);
student2.Info();
Console.WriteLine("\t");
Console.WriteLine("Teachers");
Console.WriteLine("-------------------");
BasicTeachingTeacher basicteacher = new BasicTeachingTeacher("Brent Flores", 65, "EBXcza8qghW", 1800.00, 30);
basicteacher.Info();
Console.WriteLine("-------------------");
AcademicTeacher academicteacher = new AcademicTeacher("Jared Caldwell", 59, "luqTbS8VfJJ", 1200.00, 55);
academicteacher.Info();
Console.WriteLine("\t");

