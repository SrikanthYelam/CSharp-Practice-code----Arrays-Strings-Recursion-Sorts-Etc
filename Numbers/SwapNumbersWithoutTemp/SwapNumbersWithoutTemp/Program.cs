using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbersWithoutTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 100, second = 200;
            first = first + second;
            second = first - second;
            first = first - second;

            //int i = 10, j = 30;
            //i = i + j;
            //j = i - j;
            //i = i - j;

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.Read();
        }
    }
}
