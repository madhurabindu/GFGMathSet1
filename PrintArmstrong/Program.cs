using System;

/// <summary>
/// https://practice.geeksforgeeks.org/problems/armstrong-numbers/0
/// </summary>
namespace PrintArmstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                DoOnce();
            }
        }

        private static void DoOnce()
        {
            Console.WriteLine("Enter first number ");
            string input = Console.ReadLine();

            int n1;
            Int32.TryParse(input, out n1);

            PrintAlgo(n1);
        }

        private static void PrintAlgo(int n1)
        {
            string temp = n1.ToString();
            if (temp.Length > 3)
            {
                Console.WriteLine("Enter 3 digit number");
            }

            char[] digits = temp.ToCharArray();

            double sum = 0;
            foreach (char ch in digits)
            {
                int n2;
                Int32.TryParse(ch.ToString(), out n2);
                sum = sum + Math.Pow(n2, 3);
            }

            if (sum == n1)
            {
                Console.WriteLine("{0}Yes it is armstrong", sum);
            }
            else
            {
                Console.WriteLine("{0} no it is not armstrong", sum);
            }
        }
    }
}
