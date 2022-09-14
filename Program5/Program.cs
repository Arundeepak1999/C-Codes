using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Greater value is :" + (GetAvg(21, 29)));
            Console.WriteLine("Your Greater value is :" + (GetAvg(27, 23)));
            Console.WriteLine("Your Greater value is :" + (GetAvg(77, 89)));
        }
        public static int GetAvg(int num1,int num2)
        {
            if (num1 >= 20 && num1 <= 30 && num2 >= 20 && num2 <= 30)
            {
                if (num1 >= num2)
                {
                    Console.WriteLine("value {0} is greater than {1}", num1,num2);
                    return num1;
                }
                else
                {
                    Console.WriteLine("value {0} is lesser than {1}", num2,num1);
                    return num2;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
