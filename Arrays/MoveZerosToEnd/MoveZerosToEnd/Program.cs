using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZerosToEnd
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
            output = MoveZerosToEnd(input);
            Console.WriteLine("Output : ");
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
            Console.Read();
        }

        static int[] MoveZerosToEnd(int[] input)
        {
            int curPosition = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    input[curPosition] = input[i];
                    curPosition++;
                }
            }
            for (int j = curPosition; j < input.Length; j++)
            {
                input[j] = 0;
            }
            return input;
        }
    }
}
