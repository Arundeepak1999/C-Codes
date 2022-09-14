using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your value : ");
            int rightAngle = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rightAngle; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0 }",i);
                }
            }
            Console.ReadLine();
        }
    }
}
