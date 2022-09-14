using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program15
{
    class Program
    {
        static void Main(string[] args)
        {
            double table;
            Console.Write("Enter value for creating a Multiplication table : ");
            int multiply = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                table = i * multiply;
                Console.WriteLine("{0} x {1} = {2}",i,multiply,table);
            }
            Console.ReadLine();
        }
    }
}
