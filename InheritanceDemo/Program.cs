namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("STUDENT");
            //Student student = new Student();
            //student.GetDetails();
            //student.DisplayDetails();

            //Console.WriteLine("PARTTIME");
            //PartTimeStudent partTimeStudent = new PartTimeStudent();
            //partTimeStudent.GetDetails();
            //partTimeStudent.GetPartTimeStudentDetails();
            //partTimeStudent.DisplayDetails();    
            //partTimeStudent.DisplayPartTimeStudentDetails();

            //Console.WriteLine("FULLTIME");
            //FullTimeStudent fullTimeStudent = new FullTimeStudent();
            //fullTimeStudent.GetDetails();   
            //fullTimeStudent.GetFullTimeStudentDetails();    
            //fullTimeStudent.DisplayDetails();
            //fullTimeStudent.DisplayFullTimeStudentDetails();

            PartTimeStudent p1 = new PartTimeStudent(1, "ajay", "C#", "B001", "10-2", "mon tues wed");
            p1.DisplayDetails();
            p1.DisplayPartTimeStudentDetails();


        }
    }
}
