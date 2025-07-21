namespace AbstractClassInterface_Demo
{
    abstract class Shape
    {
        protected int dim1, dim2, area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }

    }
    class Rectangle : Shape
    {
        
        public override void GetDimensions()
        {
            Console.WriteLine("enter value of l");
            dim1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("enter value of b");
            dim2 = Int16.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = dim1 * dim2;
        }
    }

    class Square : Shape
    {
        public override void CalculateArea()
        {
            area = dim1 * dim1;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("enter value for side1");
            dim1 = Int16.Parse(Console.ReadLine());
        }
    }

    class Triangle : Shape
    {
        public override void CalculateArea()
        {
            area = (int).5 * dim1 * dim2;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("enter value of h");
            dim1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("enter value of base");
            dim2 = Int16.Parse(Console.ReadLine());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            Console.WriteLine("enter shape");
            int ch = byte.Parse(Console.ReadLine());
            if (ch == 1)
            {
                shape = new Triangle();
                shape.GetDimensions();
                shape.CalculateArea();
                shape.DisplayArea();
            }
            else if (ch == 2)
                shape = new Square();
            else if (ch == 3)
                shape = new Rectangle();
            




















        }
    }
}
