using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPossibleSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            Substrings(Console.ReadLine());
            Console.Read();
        }

        static void Substrings(string str)
        {
            for (int length = 1; length < str.Length; length++)
            {
                for (int start = 0; start < str.Length - length; start++)
                {
                    Console.WriteLine(str.Substring(start, length));
                }
            }
        }
    }
}
