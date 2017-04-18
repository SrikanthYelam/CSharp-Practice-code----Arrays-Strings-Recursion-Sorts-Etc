using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsOfaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            pro pg = new pro();
            Console.WriteLine("Enter the Number : ");
            num = int.Parse(Console.ReadLine());
            result = pg.sum(num);
            Console.WriteLine("Sum of Digits in {0} is {1}", num, result);
            Console.ReadLine();
        }
    }

    class pro
    {
        public int sum(int num)
        {
            if (num != 0)
            {
                return (num % 10) + sum(num / 10);
            }
            else
            {
                return 0;
            }
        }
    }
}
