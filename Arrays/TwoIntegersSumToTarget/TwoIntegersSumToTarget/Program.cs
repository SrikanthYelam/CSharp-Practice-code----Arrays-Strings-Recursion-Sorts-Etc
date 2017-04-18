using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegersSumToTarget
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
            Console.WriteLine("Target Integer : ");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TwoIntegersSumToTarget(input, target));
            Console.Read();
        }

        static bool TwoIntegersSumToTarget(int[] x, int sum)
        {
            bool res = false;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (i != j)
                    {
                        int result = x[i] + x[j];
                        if (result == sum)
                        {
                            res = true;
                        }
                    }
                }
            }
            return res;
        }
    }
}
