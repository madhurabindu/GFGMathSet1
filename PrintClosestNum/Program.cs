using System;

namespace PrintClosestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            string input = Console.ReadLine();

            int n1;
            Int32.TryParse(input, out n1);

            Console.WriteLine("Enter second number");
            input = Console.ReadLine();

            int n2;
            Int32.TryParse(input, out n2);

            PrintClosest(n1, n2);
        }

        private static void PrintClosest(int n1, int n2)
        {
            int ans = 0;
            int mod = n1 % n2;
            if (mod < n2 / 2)
            {
                ans = n1 - mod;
            }
            else if (mod >= n2 / 2)
            {
                ans = n1 + (n2-mod);
            }
            else if (mod == 0)
            {
                ans = n1;
            }
            Console.WriteLine("Number closest to {0} divisible by {1} : {2}", n1, n2, ans);

        }
    }
}
