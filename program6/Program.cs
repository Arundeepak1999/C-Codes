using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(arr(new[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(arr(new[] { 1, 2, 1, 1, 1 }));
            Console.WriteLine(arr(new[] { 6, 4, 7, 5, 9 }));

        }
        public static int arr(int[] myarray)
        {
            for (int i = 0; i < myarray.Length-2; i++)
            {
                if (myarray[i] == 1 && myarray[i + 1] == 2 && myarray[i + 2] == 3)
                {
                    Console.WriteLine("Your Array Matches the conditions");
                    return myarray[i];
                }
            }
            Console.WriteLine("Your Array fails the conditions");
            return 0;
        }
    }
}
