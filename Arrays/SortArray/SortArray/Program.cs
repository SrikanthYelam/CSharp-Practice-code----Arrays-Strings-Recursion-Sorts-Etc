using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
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
            Array.Sort(input);
            Array.Reverse(input);
            for (int j = 0; j < input.Length; j++)
            {
                Console.WriteLine(input[j]);
            }
            Console.Read();
        }
    }
}
