using System;

namespace Practical
{
    class pra_1
    {
        static void Main(string[] args)
        {

            //for taking input from user
            Console.WriteLine("Enter First number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            float num2 = float.Parse(Console.ReadLine());

            float sum = num1 + num2;
            float sub = num1 - num2;
            float multi = num1 * num2;
            float div = num1 / num2;

            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
            Console.WriteLine("The subtraction of {0} and {1} is {2}", num1, num2, sub);
            Console.WriteLine("The multiplication of {0} and {1} is {2}", num1, num2, multi);
            Console.WriteLine("The division of {0} and {1} is {2}", num1, num2, div);
        }
    }
}

