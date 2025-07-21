using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterfaceDem
{
      interface IShape
    {
        void GetDimensions();
        void CalculateArea();
        void DisplayArea();
    }

    class Square : IShape
    {
        int side, area;
        public void CalculateArea()
        {
            area = side * side;
        }

        public void DisplayArea()
        {
            Console.WriteLine("ares is " + area);
        }

    

        public void GetDimensions()
        {
            Console.WriteLine("enter value for side1");
            side = Int16.Parse(Console.ReadLine());
        }
    }

    class Rectangle : IShape
    {
        void IShape.CalculateArea()
        {
            throw new NotImplementedException();
        }

        void IShape.DisplayArea()
        {
            throw new NotImplementedException();
        }

        void IShape.GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    interface I1
    {
        void A1();

    }

    interface I2
    {
        void A2();
    }
    interface I3
    {
        void A1();
        void A2();
        void A3();
    }

    class Demo : I1, I2
    {
        public void A1()
        {
            throw new NotImplementedException();
        }

        public void A2()
        {
            throw new NotImplementedException();
        }
    }

    class Demo2 : I1, I2, I3
    {
        public void A1()
        {
            throw new NotImplementedException();
        }

        public void A2()
        {
            throw new NotImplementedException();
        }

        public void A3()
        {
            throw new NotImplementedException();
        }
    }
    class Demo3 : I1, I2, I3
    {
        void I2.A2()
        {
            throw new NotImplementedException();
        }

        void I1.A1()
        {
            throw new NotImplementedException();
        }

        void I3.A1()
        {
            throw new NotImplementedException();
        }

        void I3.A2()
        {
            throw new NotImplementedException();
        }

        void I3.A3()
        {
            throw new NotImplementedException();
        }
    }
}

 