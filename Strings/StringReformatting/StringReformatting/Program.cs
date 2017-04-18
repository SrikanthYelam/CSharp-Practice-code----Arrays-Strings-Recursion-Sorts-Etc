using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringReformatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();
            Console.WriteLine(Reformat(s, 3));
            Console.Read();
        }

        public static string Reformat(string s, int k)
        {
            s = s.Replace("-", "");
            char[] chrArray1 = new char[10];
            char[] chrArray = s.ToCharArray();
            Array.Reverse(chrArray);
            int j = 0;
            int n = 0;
            for (int i = 0; i < chrArray.Length; i++)
            {
                if (j == k)
                {
                    chrArray1[n] = '-';
                    j = 0;
                    n++;
                    i--;
                }
                else
                {
                    chrArray1[n] = chrArray[i];
                    j++;
                    n++;
                }
            }
            Array.Reverse(chrArray1);
            string str = new string(chrArray1);
            return str;
        }
    }
}
