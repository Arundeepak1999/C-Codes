using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program17
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Descending order value :");
            int n = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                reverse = (reverse * 10) + remainder;
                n = n / 10;
            }
            System.Console.WriteLine("Reverse Order : {0}", reverse);
        }
    }
}
