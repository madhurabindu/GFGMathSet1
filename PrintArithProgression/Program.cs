using System;

/// <summary>
/// https://practice.geeksforgeeks.org/problems/series-ap/0
/// </summary>
namespace PrintArithProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            string input = Console.ReadLine();

            int n1;
            Int32.TryParse(input, out n1);

            Console.WriteLine("Enter second number ");
            input = Console.ReadLine();

            int n2;
            Int32.TryParse(input, out n2);

            Console.WriteLine("Enter index of AP serires to find ");
            input = Console.ReadLine();

            int index;
            Int32.TryParse(input, out index);

            PrintAPSeries(n1, n2, index);
        }

        private static void PrintAPSeries(int n1, int n2, int index)
        {
            string temp= n1 + ", " + n2 + " -> ";
            int diff = n2 - n1;

            index = index - 2;

            for (int i = 0; i< index; i++)
            {
                n2 = n2 + diff;
                temp = temp + n2 + ", ";
            }

            Console.WriteLine(temp);
        }
    }
}
