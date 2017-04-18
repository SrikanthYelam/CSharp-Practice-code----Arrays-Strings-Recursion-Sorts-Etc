using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers : ");
            int[] input = new int[10];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(CheckDuplicatesNew(input));
            Console.Read();
        }

        static bool CheckDuplicates(int[] input)
        {
            Dictionary<int, int> dc = new Dictionary<int, int>();

            foreach (int i in input)
            {
                if (dc.ContainsKey(i))
                {
                    return true;
                }
                else
                {
                    dc.Add(i, 1);
                }
            }
            return false;
        }

        static bool CheckDuplicatesNew(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
