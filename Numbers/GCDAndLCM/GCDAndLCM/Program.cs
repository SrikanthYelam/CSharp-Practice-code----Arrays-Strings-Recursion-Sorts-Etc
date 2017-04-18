using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDAndLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program for LCM and GCD");

            Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int gcd = GetGCD(a, b);
            int lcm = GetLCM(a, b);

            Console.WriteLine("\nGCD({0,2},{1,3}) = {2,4}", a, b, gcd);
            Console.WriteLine("\nLCM({0,2},{1,3}) = {2,4}", a, b, lcm);

            Console.WriteLine("\nGCD({0},{1}) = {2}", a, b, gcd);
            Console.WriteLine("\nLCM({0},{1}) = {2}", a, b, lcm);

            Console.Read();
        }

        static int GetGCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else if (b > a)
                {
                    b = b - a;
                }
            }
            return a;
        }

        static int GetLCM(int a, int b)
        {
            return (a * b) / GetGCD(a, b);
        }

        //GCD using recursion
        public int GCDRecursive(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
                return GCDRecursive(a % b, b);
            else
                return GCDRecursive(a, b % a);
        }
    }
}
