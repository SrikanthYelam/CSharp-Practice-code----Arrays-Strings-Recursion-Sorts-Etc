using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int power = Power(a, b);
            Console.WriteLine(power);
            Console.Read();
        }

        static int Power(int a, int b)
        {
            if (b < 0)
            {
                Console.Error.WriteLine("Usage of this function is limited to positive exponents only");
                throw new Exception();
            }
            else if (b == 1)
            {
                return a;
            }
            else if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * Power(a, b - 1);
            }
        }
    }
}
