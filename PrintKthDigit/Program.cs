using System;

/// <summary>
/// https://practice.geeksforgeeks.org/problems/print-the-kth-digit/0
/// </summary>
namespace PrintKthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                DoOnce();
            }
        }

        private static void DoOnce()
        {
            Console.WriteLine("Enter A number ");
            string input = Console.ReadLine();

            Console.WriteLine("Enter Kth Index: ");
            string input2 = Console.ReadLine();

            int n1;
            Int32.TryParse(input2, out n1);
            if (n1 > 0)
            {
                PrintAlgo(input, n1);
            }
        }

        private static void PrintAlgo(string input, int index)
        {
            char[] digits = input.ToCharArray();

            Console.WriteLine("{0}th digit in number {1} is : {2}\n", index, input, digits[index-1]);
        }
    }
}
