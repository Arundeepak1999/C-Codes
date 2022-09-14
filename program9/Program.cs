using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of m : ");
            int m = int.Parse(Console.ReadLine());
            if (m > 0)
            {
                Console.WriteLine("Value of n is 1");
            }
            else if (m == 0)
            {
                Console.WriteLine("Value of n is 0");
            }
            else
            {
                Console.WriteLine("Value of n is -1");
            }
            Console.ReadLine();
        }
    }
}
