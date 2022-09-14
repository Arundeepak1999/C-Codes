using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of c :");
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is greater than {1} and {2} : ", a,b,c);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("{0} is greater than {1} and {2} : ", b,a,c);
            }
            else if (c > a && c >b)
            {
                Console.WriteLine("{0} is greater than {1} and {2} : ", c,a,b);
            }
            else
            {
                Console.WriteLine("Enter the vaild number");
            }
            Console.ReadLine();
        }
    }
}
