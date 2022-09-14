using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            CompValue(50);
            CompValue(110);
        }
        public static bool CompValue(int num)
        {
            if (num >= 10 && num <= 100)
            {
                Console.WriteLine("Your value {0} is located between 10 to 100", num);
                return true;
            }
            else
            {
                Console.WriteLine("Your value {0} is located not in between 10 to 100", num);
                return false;
            }
        }
    }
}
