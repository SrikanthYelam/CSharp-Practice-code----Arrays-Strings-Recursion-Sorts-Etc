using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            Console.WriteLine(FactorialNew(Convert.ToInt32(Console.ReadLine())));
            Console.Read();
        }

        //using recursion
        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //using for loop
        static int FactorialNew(int n)
        {
            int result = 1;
            for (int i = n; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
}
