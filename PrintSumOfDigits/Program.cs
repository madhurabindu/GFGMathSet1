using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://practice.geeksforgeeks.org/problems/sum-of-digit-is-pallindrome-or-not/0
/// </summary>
namespace PrintSumOfDigits
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
            string temp = n1.ToString();
            char[] digits = temp.ToCharArray();

            int sum = 0;
            foreach (char ch in digits)
            {
                int n2;
                Int32.TryParse(ch.ToString(), out n2);
                sum = sum + n2;
            }

            Console.WriteLine("Sum of digits of {0} is : {1}\n", n1, sum);
            if (Reverse(sum.ToString()) == sum.ToString())
            {
                Console.WriteLine("AND its a palindrome!!!");
            }
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
