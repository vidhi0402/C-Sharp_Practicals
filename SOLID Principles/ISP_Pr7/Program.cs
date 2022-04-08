using System;

namespace ISP_Pr7
{
    interface IFour
    {
        public void four_wheeler();
    }
    interface IThree
    {
        public void three_wheeler();

    }
    interface ITwo
    {
        public void two_wheeler();

    }
    class Car : IFour
    {
        public void four_wheeler()
        {
            Console.WriteLine("This is Car Class");
        }
    }
    class Auto : IThree
    {
        public void three_wheeler()
        {
            Console.WriteLine("This is Auto Class");
        }
    }
    class Bike : ITwo
    {
        public void two_wheeler()
        {
            Console.WriteLine("This is Bike Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.four_wheeler();
            Auto a = new Auto();
            a.three_wheeler();
            Bike b = new Bike();
            b.two_wheeler();
        }
    }
}