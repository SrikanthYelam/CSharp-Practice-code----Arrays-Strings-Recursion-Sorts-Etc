using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            Console.WriteLine(Count(Console.ReadLine()));
            Console.Read();
        }

        static int Count(string str)
        {
            if (str == "")
            {
                return 0;
            }
            else
            {
                while (str.Contains("  "))
                {
                    str = str.Replace("  ", " ");
                }
                string[] str1 = str.Split(' ');
                return str1.Count();
            }
        }
    }
}
