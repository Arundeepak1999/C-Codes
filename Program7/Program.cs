using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year : ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Given year is Leap year " + year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Given year is Leap year " + year);
            }
            else if (year % 400 ==0)
            {
                Console.WriteLine("Given year is Leap year " + year);
            }
            else
            {
                Console.WriteLine("Given year is not a Leap year " + year);
            }
            Console.ReadLine();
        }
    }
}
