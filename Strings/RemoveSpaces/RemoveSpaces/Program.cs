using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            Console.WriteLine(RemoveSpaces(Console.ReadLine()));
            Console.Read();
        }

        static string RemoveSpaces(string str)
        {
            str = str.Replace(" ", "");
            return str;
        }
    }
}
