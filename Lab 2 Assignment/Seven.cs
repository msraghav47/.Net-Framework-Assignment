using System;
namespace Lab27
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("Circle Area: " + circle.CalculateArea());

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        }
    }
}
