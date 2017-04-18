using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 6, 7, 4, 1, 8, 3, 5 };
            InsertionSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.Read();
        }

        static void InsertionSort(int[] array)
        {
            //int i, j;
            //for (i = 1; i < data.Length; i++)
            //{
            //    int item = data[i];
            //    int ins = 0;
            //    for (j = i - 1; j >= 0 && ins != 1; )
            //    {
            //        if (item < data[j])
            //        {
            //            data[j + 1] = data[j];
            //            j--;
            //            data[j + 1] = item;
            //        }
            //        else ins = 1;
            //    }
            //}

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while ((j > 0) && (array[j] < array[j - 1]))
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;

                    j--;
                }
            }
        }
    }
}
