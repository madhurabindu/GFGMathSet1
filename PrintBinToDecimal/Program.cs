using System;

/// <summary>
/// https://practice.geeksforgeeks.org/problems/binary-number-to-decimal-number/0
/// </summary>
namespace PrintBinToDecimal
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

            PrintAlgo(input);
        }

        private static void PrintAlgo(string input)
        {
            char[] digits = input.ToCharArray();

            int num = 0;
            int len = digits.Length-1;

            foreach(char ch in digits)
            {
                int temp = Int32.Parse(ch.ToString());

                num = num + temp *(int)( Math.Pow(2, len--));
            }
            Console.WriteLine("Binary number: {0} and decimal: {1} \n", input, num);
        }
    }


}
