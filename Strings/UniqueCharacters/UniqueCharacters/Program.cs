using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            Console.WriteLine(Unique(Console.ReadLine()));
            Console.Read();
        }

        static bool Unique(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char ch in str)
            {
                if (dict.ContainsKey(ch))
                {
                    return false;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            return true;
        }
    }
}
