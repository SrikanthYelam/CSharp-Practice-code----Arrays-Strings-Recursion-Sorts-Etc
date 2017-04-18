using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();
            Console.WriteLine(RemoveDuplicates(s));
            Console.ReadLine();
        }

        public static string RemoveDuplicates(string value)
        {
            string result = "";

            foreach (char val in value)
            {
                if (result.IndexOf(val) == -1)
                {
                    result += val;
                }
            }
            return result;
        }
    }
}
