using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program14
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            double cube;
            Console.Write("Enter the value : ");
            value = int.Parse(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {
                cube = Math.Pow(i, 3);
                Console.WriteLine("Cube value of {1} is : {0}", cube,i);
            }
            Console.ReadLine();
        }
    }
}
