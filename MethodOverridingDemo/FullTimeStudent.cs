
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
    internal class FullTimeStudent  : Student   
    {
        string classNum;
        DateOnly dateOfJoining;
        public override void GetDetails()
        {
            base.GetDetails();  
            Console.WriteLine("enter classNum");
            classNum = Console.ReadLine();
            Console.WriteLine("enter dateOfJoining");
            dateOfJoining = DateOnly.Parse(Console.ReadLine());
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"classNum is {classNum}\ndateOfJoining is {dateOfJoining}");
        }
    }
}
