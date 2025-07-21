namespace AbstractClassInterfaceDemo
{
    class Rectangle
    {
        int l, b, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter value of l");
            l = Int16.Parse(Console.ReadLine());
            Console.WriteLine("enter value of b");
            b = Int16.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = l * b;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    class Square
    {
        int side, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter value of side");
            side = Int16.Parse(Console.ReadLine());
           
        }
        public void CalculateArea()
        {
            area = side* side;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    class Triangle
    {
        int h, Base, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter value of h");
            h = Int16.Parse(Console.ReadLine());
            Console.WriteLine("enter value of base");
            Base = Int16.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = (int).5*Base * h;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
