namespace MultilevelInheritanceDemo
{
   class Student
    {
        int rn;
        string name;
        public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("rn is " + rn);
            Console.WriteLine("name is " + name);
        }
    }
    class Test : Student
    {
        int[] marks = [90, 89, 67, 90, 89];
        protected int total = 0;
        public void CalculateTotalMarks()
        {
            foreach (var mark in marks)
            {
                total += mark;
            }
        }
    
        public void DisplayDetails()
        {
            base.DisplayDetails();

            Console.WriteLine("Total Marks are " + total);
        }
    }
    class Sports : Test
    {
        string sportsName;
        protected int score;
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter sportsName ");
            sportsName = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {

            base.DisplayDetails();
            Console.WriteLine("sports Name is " + sportsName);
            Console.WriteLine("Score is " + score);
        }
    }
    class Result : Sports
    {
        int totalScore;
        public void CalculateTotalScore()
        {
            totalScore = total + score;
        }
        public void DisplayDetails()
        {

            base.DisplayDetails();
            Console.WriteLine("totalScore " + totalScore);

        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {

                Result result = new Result();
                //result.score = 100;
                //result.total = 90;
                result.GetDetails();
                result.CalculateTotalMarks();
                result.CalculateTotalScore();
                result.DisplayDetails();
            }
        }
    }

}