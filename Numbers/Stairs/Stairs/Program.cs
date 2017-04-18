using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Stairs : ");
            Console.WriteLine(CombosRecursive(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }

        public static int CombosRecursive(int numStairs)
        {
            if (numStairs > 36)
                throw new Exception("Int overflow");
            if (numStairs <= 0)
                return 0;
            if (numStairs == 1)
                return 1;
            if (numStairs == 2)
                return 2;
            if (numStairs == 3)
                return 4;
            return CombosRecursive(numStairs - 1) + CombosRecursive(numStairs - 2) + CombosRecursive(numStairs - 3);
        }
    }
}
