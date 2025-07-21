using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
    internal class Student
    {
        int rn;
        string name;
        string course;
        string batch;
        public Student() { }
        public Student(int rn, string name, string course, string batch)
        {
            this.rn = rn;
            this.name = name;
            this.course = course;
            this.batch = batch;
        }
       virtual public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter course");
            course = Console.ReadLine();
            Console.WriteLine("enter batch");
            batch = Console.ReadLine();
        }
        virtual public void DisplayDetails()
        {
            Console.WriteLine($"Rn is {rn}\nName is {name}\nBatch is {batch}\nCourse is {course}");
        }

        }
    }

