using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monograms.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMonogram("K", "W", "H");
            DisplayMonogram("S", "T", "R");
            Console.ReadLine();
        }
        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2} **", first, middle, last);
        }
    }
}
