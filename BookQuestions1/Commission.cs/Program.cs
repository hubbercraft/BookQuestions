using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commission.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string Carprice;
            double Commission;
            double value;

            Console.WriteLine("What is the price of the car?");
            Carprice = Console.ReadLine();
            value = Convert.ToDouble(Carprice);
            
            if (value <= 15000)
            {
                Commission = value * .05;
            }
            else if (value <= 24000 && value > 15000)
            {
                Commission = value * .07;
            }

            else 
            {
                Commission = value * .10;
            }
            Console.WriteLine("Your commission is: $" + Commission);
        }
    }
}
