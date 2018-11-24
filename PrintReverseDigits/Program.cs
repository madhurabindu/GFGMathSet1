using System;

namespace PrintReverseDigits
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
            Console.WriteLine("Enter first number ");
            string input = Console.ReadLine();

            int n1;
            Int32.TryParse(input, out n1);

            PrintAlgo(n1);
        }

        private static void PrintAlgo(int n1)
        {
            Console.WriteLine("{0} AND reversed {1} !!!\n", n1.ToString(), Reverse(n1.ToString()));
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
