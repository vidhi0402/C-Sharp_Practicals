using System;

namespace Polymorphism
{
    class Bird
    {
        public void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
    class Duck : Bird
    {
        public void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Bird myBird = new Bird();

            Duck myDuck = new Duck();

            myBird.Voice();

            myDuck.Voice();
        }
    }
}
