using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfInt
{
    class Program
    {
        int Num1;
        int Num2;
        int Sum;
        static void Main(string[] args)
        {
            Console.WriteLine("The Sum of Two Integers with triple values : {0} ", Calc(5,5));
            Console.WriteLine("The Sum of Two Integers with triple values : {0} ", Calc(11, 5));
            Console.WriteLine("The Sum of Two Integers with triple values : {0} ", Calc(-3, 4));
        }
        public static int Calc(int Num1, int Num2)
        {
            int Sum = Num1 + Num2;
            if (Num1 == Num2)
            {
                Console.WriteLine("Integers are equal :");
                return Sum*3;
            }
            else
            {
                Console.WriteLine("Integers are not equal :");
            }
            return Sum;
        }
    }
}
