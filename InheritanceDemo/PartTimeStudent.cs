using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class PartTimeStudent : Student
    {
        string slot;
        string days;
        public PartTimeStudent() : base() { }
        public PartTimeStudent(int rn, string name, string course, string batch,
            string slot, string days): base (rn , name, course,batch)
        {
            this.slot = slot;   
            this.days = days;
        }

        public void GetPartTimeStudentDetails()
        {
            Console.WriteLine("enter slot");
            slot = Console.ReadLine();
            Console.WriteLine("enter days");
            days = Console.ReadLine();
        }
        public void DisplayPartTimeStudentDetails()
        {
            Console.WriteLine($"Slot selected is {slot}\nDays selected are {days}");
        }
    }
}
