using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter str1 : ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter str2 : ");
            string s2 = Console.ReadLine();

            Console.WriteLine(IsAnagramsNew(s1, s2));
            Console.ReadLine();
        }

        static bool IsAnagrams(string str1, string str2)
        {
            bool b1 = false;
            bool b2 = false;
            bool result = false;

            foreach (char val in str1)
            {
                if (str2.ToLower().IndexOf(val.ToString().ToLower()) != -1)
                {
                    b1 = true;
                }
                else
                {
                    b1 = false;
                    break;
                }
            }

            foreach (char val in str2)
            {
                if (str1.ToLower().IndexOf(val.ToString().ToLower()) != -1)
                {
                    b2 = true;
                }
                else
                {
                    b2 = false;
                    break;
                }
            }

            if (b1 == true && b2 == true)
            {
                result = true;
            }

            return result;
        }

        static bool IsAnagramsNew(string word1, string word2)
        {
            char[] chrArray1 = word1.ToLower().ToCharArray();
            char[] chrArray2 = word2.ToLower().ToCharArray();

            Array.Sort(chrArray1);
            Array.Sort(chrArray2);

            string str1 = new string(chrArray1);
            string str2 = new string(chrArray2);

            if (str1 == str2)
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
