using System;

namespace Abstraction
{
    public class Laptop
    {
        private string brand;
        private string model;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public void LaptopDetails()
          {
             Console.WriteLine("Brand: " + Brand);
             Console.WriteLine("Model: " + Model);
          }


        private void MotherBoardInfo()

        {
            Console.WriteLine("MotherBoard Information");
        }
        public static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.Brand = "Samsung";
            laptop.Model = "Galaxy M42";
            laptop.LaptopDetails();
            laptop.MotherBoardInfo();

        }
    }
}