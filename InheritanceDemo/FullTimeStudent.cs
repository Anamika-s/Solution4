
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class FullTimeStudent  : Student   
    {
        string classNum;
        DateOnly dateOfJoining;

        // Student(12,12,12,12)
        public FullTimeStudent() { }
        public FullTimeStudent(int rn, string name, string course, string batch, string classNum,
            DateOnly dateOfJoining)  : base (rn, name, course, batch)
        { 
            this.classNum = classNum;   
            this.dateOfJoining = dateOfJoining; 
        } 
        public void GetFullTimeStudentDetails()
        {
            Console.WriteLine("enter classNum");
            classNum = Console.ReadLine();
            Console.WriteLine("enter dateOfJoining");
            dateOfJoining = DateOnly.Parse(Console.ReadLine());
        }
        public void DisplayFullTimeStudentDetails()
        {
            Console.WriteLine($"classNum is {classNum}\ndateOfJoining is {dateOfJoining}");
        }
    }
}
