using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteDifference
{
    class Program
    {
        int n;
        static void Main(string[] args)
        {
            Console.WriteLine("Triple value of absolute difference is : {0}", AbsoluteVal(60));
        }
        public static int AbsoluteVal(int n)
        {
            int num = 51;
            if (n > num)
            {
                Console.WriteLine("value {1} greater than {0}", num,n);
                return (n - num) * 3; 
            }
            else
            {
                Console.WriteLine("value {1} lesser than {0}", num,n);
            }
            return (num - n);
        }
    }
}
