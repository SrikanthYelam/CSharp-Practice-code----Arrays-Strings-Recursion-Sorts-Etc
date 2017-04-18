using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            Console.WriteLine(PalindromeNew(Console.ReadLine()));
            Console.Read();
        }

        static bool Palindrome(string str)
        {
            char[] chrArray = str.ToLower().ToCharArray();
            Array.Reverse(chrArray);
            string str1 = new string(chrArray);
            if (str.ToLower() == str1.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool PalindromeNew(string str)
        {
            int min = 0;
            int max = str.Length - 1;

            while (true)
            {
                if (str[min] != str[max])
                {
                    return false;
                }

                if (min == max)
                {
                    return true;
                }

                min++;
                max--;
            }
        }
    }
}
