using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            Console.WriteLine(ReverseIteration(Console.ReadLine()));
            Console.Read();
        }

        static string Reverse(string word1)
        {
            char[] chrArray = word1.ToCharArray();
            Array.Reverse(chrArray);
            return new string(chrArray);
        }

        static string ReverseIteration(string word1)
        {
            string str1 = "";
            int i = word1.Trim().Length;
            for (int j = i - 1; j >= 0; j--)
            {
                str1 += word1[j];
            }
            return str1;
        }
    }
}
