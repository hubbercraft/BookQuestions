using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            int[] AreaCodes = new int[6] { 262, 414, 608, 715, 815, 920 };
            double[] Rates = new double[6] { .07, .10, .05, .16, .24, .14 };
            string Area;
            string minutes;


            Console.WriteLine("What is your area code?");
            Area = Console.ReadLine();
            Console.WriteLine("What was the length of your call in minutes?");
            minutes = Console.ReadLine();

            for (int i = 0; i < AreaCodes.Length; i++) 
            {
                if (Area == AreaCodes[i].ToString())
                {
                    price = Rates[i] * Convert.ToInt32(minutes);
                    Console.WriteLine(price.ToString("C"));
                }
            }
        }
    }
}
