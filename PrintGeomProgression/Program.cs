using System;

/// <summary>
/// https://practice.geeksforgeeks.org/problems/series-gp/0
/// </summary>
namespace PrintGeomProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            string input = Console.ReadLine();

            int n1;
            Int32.TryParse(input, out n1);

            Console.WriteLine("Enter common ration");
            input = Console.ReadLine();

            int n2;
            Int32.TryParse(input, out n2);

            Console.WriteLine("Enter index of GP serires to find ");
            input = Console.ReadLine();

            int index;
            Int32.TryParse(input, out index);

            PrintAPSeries(n1, n2, index);
        }

        private static void PrintAPSeries(int n1, int cr, int index)
        {
            string temp = string.Empty;

            for (int i = 1; i < index; i++)
            {
                int n2 =n1 * (int) Math.Pow(cr,i);
                temp = temp + n2 + ", ";
            }

            Console.WriteLine(temp);
        }
    }
}
