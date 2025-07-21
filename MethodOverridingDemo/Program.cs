namespace MethodOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PartTimeStudent partTimeStudent = new PartTimeStudent();
            //partTimeStudent.GetDetails();
            ////partTimeStudent.GetPartTimeStudentDetails();

            //partTimeStudent.DisplayDetails();
            ////partTimeStudent.DisplayPartTimeStudentDetails();

            //FullTimeStudent fullTimeStudent = new FullTimeStudent();    
            //fullTimeStudent.GetDetails();
            //fullTimeStudent.DisplayDetails();
            //// Student student = new Student();

            // we want to access the partTime & fullTime students thru student class 

            Student student;
            Console.WriteLine("enter wanyt to enter details for Partime or fulltime" +
                "1 means parttime\n2 means fulltime");
            int ch = byte.Parse(Console.ReadLine());
            if(ch==1)
           
                student = new PartTimeStudent();
            else
                student= new FullTimeStudent();

            student.GetDetails();
            student.DisplayDetails();
        }
    }
}
