using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter a number to be squared and cubed");
            input = Console.ReadLine();

            Console.WriteLine(Math.Pow(Convert.ToInt32(input), 2));
            Console.WriteLine(Math.Pow(Convert.ToInt32(input), 3));
        }
    }
}
