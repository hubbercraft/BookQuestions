using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookQuestions
{
    class CheckZips
    {
        static void Main(string[] args)
        {
            int[] ZipCodes = new int[10];
            ZipCodes[0] = 12345;
            ZipCodes[1] = 12346;
            ZipCodes[2] = 12347;
            ZipCodes[3] = 12348;
            ZipCodes[4] = 12349;
            ZipCodes[5] = 12350;
            ZipCodes[6] = 12351;
            ZipCodes[7] = 12352;
            ZipCodes[8] = 12353;
            ZipCodes[9] = 12354;

            Console.WriteLine("WAT is your zipcode?");
            string input = Console.ReadLine();
            for (int i = 0; i < ZipCodes.Length; i++)
            {
                if(input == ZipCodes[i].ToString())
                {
                    Console.WriteLine("Yes, we deliever to you, Monty Phython.");
                    break;
                }
                else   
                    Console.WriteLine("Sorry beb, but we don't deliver to you.");              
            }
        }
    }
}
