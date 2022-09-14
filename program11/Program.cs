using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks in maths :");
            int maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks in physics :");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks in chemistry :");
            int chemistry = int.Parse(Console.ReadLine());
            int total = maths + physics + chemistry;
            int avgTotal = maths + physics;
            if (maths >= 65 && physics >= 55 && chemistry >= 50)
            {
                if (total >= 180 || avgTotal >= 140)
                {
                    Console.WriteLine("You are eligible for admission");
                }
                else
                {
                    Console.WriteLine("You are not eligible for admission");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible for admission");
            }
            Console.ReadLine();
        }
    }
}
