using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 6, 7, 4, 1, 8, 3, 5 };
            SelectionSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.Read();
        }

        static void SelectionSort(int[] array)
        {
            int temp, k = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                k = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[k])
                    {
                        k = j;
                    }
                }
                temp = array[k];
                array[k] = array[i];
                array[i] = temp;
            }
        }
    }
}
