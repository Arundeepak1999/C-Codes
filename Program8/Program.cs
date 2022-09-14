using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible for voting!");
            }
            else
            {
                Console.WriteLine("Your are not eligible for voting at this age");
            }
            Console.ReadLine();
        }
    }
}
