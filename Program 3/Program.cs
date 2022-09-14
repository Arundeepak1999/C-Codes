using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolCondition
{
    class Program
    {
        int num1;
        int num2;
        static void Main(string[] args)
        {
            check(30, 46);
            check(50, 30);
            check(323, 136);
            Console.ReadLine();
        }
        public static bool check(int num1, int num2)
        {
            if (num1 == 30 || num2 == 30)
            {
                Console.WriteLine("your value is equal to the 30");
                return true;
            }
            Console.WriteLine("your value is not equal to the 30");
            return false;
        }
    }
}
