using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] search = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int target = 7;
            int result = BinarySearch(search, target, 1, 8);
            Console.WriteLine(result);
            Console.Read();
        }

        static int BinarySearch(int[] search, int key, int min, int max)
        {
            //if (min > max)
            //{
            //    return 0;
            //}
            int mid = (min + max) / 2;

            if (key == search[mid])
            {
                return ++mid;
            }
            else if (key < search[mid])
            {
                return BinarySearch(search, key, min, mid - 1);
            }
            else
            {
                return BinarySearch(search, key, mid + 1, max);
            }
        }
    }
}
