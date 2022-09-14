using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.Write("Enter the value of natural number n : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Natural number is :{0} ", n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ",i);
                sum = sum + i;
            }
            Console.WriteLine("\nSum of all the natural numbers : {0}", sum);
            Console.ReadLine();
        }
    }
}
