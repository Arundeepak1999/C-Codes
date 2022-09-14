using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program12
{
    class Program
    {
        int rollNum, phy, chem, ca, total;
        double percent;
        string name, div;
        static void Main(string[] args)
        {
            string name = "James";
            int rollNum = 784;
            int phy = 70;
            int chem = 80;
            int ca = 90;
            int total = phy + chem + ca;
            double percent = total / 3.0;
            Console.WriteLine("Your Roll Number : {0}", rollNum);
            Console.WriteLine("Your Name : {0}", name);
            Console.WriteLine("Your marks \nPhysics : {0} \nchemistry : {1} \nComputer Application : {2} \nTotal Marks : {3} \nYour Percentage : {4}", phy, chem, ca, total, percent);
            if (percent >= 70)
            {
              Console.WriteLine("Your division is First class");
            }
            else if (percent <70 && percent >= 50)
            {
                Console.WriteLine("Your division is Second class");
            }
            else
            {
                Console.WriteLine("Your are Failed");
            }
            Console.ReadLine();
        }
    }
}
