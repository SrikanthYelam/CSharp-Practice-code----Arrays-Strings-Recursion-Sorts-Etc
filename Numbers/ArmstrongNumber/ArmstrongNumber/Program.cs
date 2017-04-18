using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------
            //Below code works only for 3 digit numbers 
            
            //int number, remainder, sum = 0;
            //Console.WriteLine("Enter the Number");
            //number = int.Parse(Console.ReadLine());
            //for (int i = number; i > 0; i = i / 10)
            //{
            //    remainder = i % 10;
            //    sum = sum + remainder * remainder * remainder;

            //}
            //if (sum == number)
            //{
            //    Console.WriteLine("Entered Number is an Armstrong Number");
            //}
            //else
            //    Console.WriteLine("Entered Number is not an Armstrong Number");
            //Console.ReadLine();
            //------------------------------------------------------------------------

            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsArmstrong(num));
            Console.Read();
        }

        static bool IsArmstrong(int n)
        {
            //double log = Math.Log10(n);
            int digitsCount = Convert.ToInt32(Math.Floor(Math.Log10(n))) + 1;
            int total = 0;
            int num = n;

            for (int i = 0; i < digitsCount; i++)
            {
                int r = num % 10;
                total = total + Convert.ToInt32(Math.Pow(r, digitsCount));
                num = num / 10;
            }

            if (total == n)
            {
                return true;
            }
            return false;
        }
    }
}
