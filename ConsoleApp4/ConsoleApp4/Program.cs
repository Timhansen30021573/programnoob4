using System;
//* Tim Hansen finding if number is larger *//
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int fnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int snum = int.Parse(Console.ReadLine());

            if (fnum == snum)
                Console.WriteLine("These two numbers are the same or equal");
            else if (fnum > snum)
                Console.WriteLine($"the first number entered,{fnum} is the larger of the two");
            else
                Console.WriteLine($"the second number entered,{snum} is the larger of the two");
            Console.ReadLine();


           
         
        }
    }
}
