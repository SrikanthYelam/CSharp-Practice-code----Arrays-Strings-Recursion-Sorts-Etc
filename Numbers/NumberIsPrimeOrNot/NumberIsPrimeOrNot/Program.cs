using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberIsPrimeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program for Prime Number");

            Console.WriteLine("Enter the Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isPrime = IsPrime(a);

            if (isPrime)
            {
                Console.WriteLine(a + " is a Prime number");
            }
            else
            {
                Console.WriteLine(a + " is not a Prime number");
            }

            Console.Read();
        }

        static bool IsPrime(int num)
        {
            int k = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
