using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Array : ");
            int[] input1 = new int[10];
            for (int i = 0; i < input1.Length; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter 2nd Array : ");
            int[] input2 = new int[10];
            for (int i = 0; i < input2.Length; i++)
            {
                input2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Merged Array : ");
            int[] output = new int[20];
            output = MergedArray(input1, input2);
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
            Console.Read();
        }

        static int[] MergedArray(int[] input1, int[] input2)
        {
            int[] output = new int[20];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = input1[i];
            }
            int k=0;
            for (int j = input1.Length; j < input2.Length + input1.Length; j++)
            {
                output[j] = input2[k];
                k++;
            }
            Array.Sort(output);
            return output;
        }
    }
}
