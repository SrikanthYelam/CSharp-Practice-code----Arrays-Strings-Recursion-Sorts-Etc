using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapMinMax
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
            int[] output = new int[10];
            output = SwapMinMax(input);
            Console.WriteLine("Swapped output : ");
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
            Console.Read();
        }

        static int[] SwapMinMax(int[] input)
        {
            //Array.Sort(input);
            //int temp = input[input.Length - 1];
            //input[input.Length - 1] = input[0];
            //input[0] = temp;
            //return input;

            int min = 0;
            int max = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[min] > input[i])
                {
                    min = i;
                }
                if (input[max] < input[i])
                {
                    max = i;
                }
            }

            int temp = input[min];
            input[min] = input[max];
            input[max] = temp;

            return input;
        }
    }
}
