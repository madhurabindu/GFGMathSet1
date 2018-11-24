using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://practice.geeksforgeeks.org/problems/print-the-pattern-set-1/1
/// </summary>
namespace printpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number;
            Int32.TryParse(input, out number);

            printPattern(number);

            Console.ReadLine();
        }

        static void printPattern(int number)
        {
            for (int i = number; i >= 1; --i)
            {
                for (int j = number; j >= 1; j--)
                {
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(string.Format("{0}", j));
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
