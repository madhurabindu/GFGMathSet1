using System;

/// <summary>
/// https://practice.geeksforgeeks.org/problems/print-table/0
/// </summary>
namespace PrintTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number;
            Int32.TryParse(input, out number);

            PrintTable(number);

        }

        public static void PrintTable(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0,2} x {1,2} = {2,2}", n, i, n*i);
            }
        }
    }
}
