using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            var number2 = int.Parse(Console.ReadLine());

            var result = number1 + number2;

            Console.WriteLine($"Calculated sum is: {result}");
        }
    }
}
