
using System;
using System.Linq;

namespace Practical_4
{
    class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        public static decimal AverageMarks;
        public decimal CalculateAverageMarks()
        {
            decimal marks = 0;
            foreach (decimal i in Marks)
            {
                marks += i;
            }
            return marks / 5;
        }
        public string CalculateGrade(decimal marks)
        {
            string grade = "";
            switch ((int)marks / 10)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                default:
                    grade = "D";
                    break;

            }
            return grade;
        }

    }
    public enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter student Name : ");
            string sname = Console.ReadLine();
            Console.Write("Enter Marks : ");
            decimal[] arr = new decimal[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDecimal(Console.ReadLine());
            }
            Student S = new Student();
            S.Name = sname;
            S.Marks = arr;
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("----------------Menu----------------");
                Console.WriteLine("1 - Aggregate");
                Console.WriteLine("2 - MinMark");
                Console.WriteLine("3 - MaximumMark");
                Console.WriteLine("4 - Grade");
                Console.Write("Enter Choice : ");
                int ch = int.Parse(Console.ReadLine());
                Options input = (Options)ch;
                switch (input)
                {
                    case Options.Aggregate:
                        Console.WriteLine("");
                        Console.Write($"Student Name : {S.Name}");
                        Console.WriteLine("");
                        Console.WriteLine($"Average Marks : {S.CalculateAverageMarks()}");
                        break;
                    case Options.MinMark:
                        Console.WriteLine("");
                        Console.WriteLine($"Minimum Marks : {S.Marks.Min()}");
                        break;
                    case Options.MaximumMark:
                        Console.WriteLine("");
                        Console.WriteLine($"Maximum Marks : {S.Marks.Max()}");
                        break;
                    case Options.Grade:
                        Console.WriteLine("");
                        Console.WriteLine($"Grade : {S.CalculateGrade(S.CalculateAverageMarks())}");
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Wrong Option Chosen...");
                        break;

                }

            }


        }
    }
}
