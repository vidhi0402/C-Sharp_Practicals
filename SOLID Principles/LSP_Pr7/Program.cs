using System;

namespace LSP_Pr7

{
    public class Bird
    {
        public void walk()
        {

            Console.WriteLine("I'm Walking");

        }
    }
    public class FlyingBirds : Bird
    {
        public void fly()
        {
            Console.WriteLine("I'm Flying");
        }
    }
    public class Duck : FlyingBirds
    {
        public void duck()
        {
            Console.WriteLine("I'm Duck");
        }
    }
    public class Penguin : Bird
    {
        public void penguin()
        {
            Console.WriteLine("I'm Penguin");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duck d = new Duck();
            d.duck();
            d.fly();
            d.walk();
            Penguin p = new Penguin();
            p.penguin();
            p.walk();
        }
    }
}