using System;

namespace OCP_Pr7

{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
    public class Square : Shape
    {
        public double length { get; set; }
        public override double Area()
        {
            return length * length;
        }
    }
    class Program
    {
        public static double Area(Shape shape)
        {
            if (shape == null)
            {
                throw new Exception("Can not find srea");
            }
            return shape.Area();
        }
        static void Main(string[] args)
        {

            Rectangle s = new Rectangle();
            s.Height = 10;
            s.Width = 20;
            Console.WriteLine(Area(s));
            Square sq = new Square();
            sq.length = 10;
            Console.WriteLine(Area(sq));


        }
    }
}