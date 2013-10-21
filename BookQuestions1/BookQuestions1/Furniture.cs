using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookQuestions
{
    class Furniture
    {
        static void Main(string[] args)
        {
            int Price = 0;
            Console.WriteLine("(P)ine, (O)ak, (M)ahogany");
            string input = Console.ReadLine();
            if (input == "P")
            {
                Price += 100;
                Console.Write(Convert.ToInt32(Price));
            }
            else if (input == "O")
            {
                Price += 225;
                Console.Write(Convert.ToInt32(Price));
            }
            else if (input == "M")
            {
                Price += 310;
                Console.Write(Convert.ToInt32(Price));
            }
            else
            {
                Price += 0;
            }

        }
    }
}
