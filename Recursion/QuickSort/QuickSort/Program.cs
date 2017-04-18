using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 6, 7, 4, 1, 8, 3, 5 };
            QuickSort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.Read();
        }

        static void QuickSort(int[] array, int left, int right)
        {
            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);
            if (index > 1)
            {
                QuickSort(array, left, index);
            }
            QuickSort(array, index + 1, right);           
        }

        static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }
            return right;
        }
    }
}
