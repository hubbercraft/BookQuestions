using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usingsums.cs
{
    class Program
    {
       public static void Main()
        {
            Console.WriteLine("Enter number of integers:");
            string lengthint = Console.ReadLine();
            int length = Convert.ToInt32(lengthint);
            Sum(length);
            Console.ReadKey();

        }
        public static void Sum(int length)
        {
        int[] sum = new int[length];
            int result = 0;

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write("Input integer #{0}:", i + 1);
                string input = Console.ReadLine();
                sum[i] = Convert.ToInt32(input);
                result += sum[i];
            }
            Console.WriteLine("Your sum is {0}", result);
        }
    }
}
