using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostOccurredElement
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
            Console.WriteLine("Majority Value : " + MostOccurred(input));
            Console.Read();
        }

        static int MostOccurred(int[] input)
        {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int majority = input.Length / 2;

            foreach (int i in input)
            {
                if (dc.ContainsKey(i))
                {
                    dc[i]++;
                    if (dc[i] > majority)
                        return i;
                }
                else
                {
                    dc.Add(i, 1);
                }
            }
            throw new Exception("No majority element in this array");
        }
    }
}
